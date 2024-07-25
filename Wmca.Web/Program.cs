WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins",
        builder =>
        {
            builder.WithOrigins("https://dev-wmca.euwest01.umbraco.io", "https://www.wmca.org.uk", "http://localhost:1234/") // Replace with your allowed origins
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddDeliveryApi()
    .AddComposers()
    .AddAzureBlobMediaFileSystem()
    .AddAzureBlobImageSharpCache()
    .Build();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();

#if (UseHttpsRedirect)
app.UseHttpsRedirection();
#endif

app.UseCors("MyAllowSpecificOrigins");

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