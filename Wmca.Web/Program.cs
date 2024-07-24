WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddComposers()
    .AddAzureBlobMediaFileSystem()
    .AddAzureBlobImageSharpCache()
    .Build();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();

#if (UseHttpsRedirect)
app.UseHttpsRedirection();
#endif

app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.RunPrePipeline();
        u.RunPreRouting();
        u.RunPostPipeline();
        u.RunPostRouting();
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseInstallerEndpoints();
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();