using Our.Umbraco.PersonalisationGroups.Core;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddDeliveryApi()
    .AddComposers()
    .AddAzureBlobMediaFileSystem()
    .AddAzureBlobImageSharpCache()
    .AddPersonalisationGroups(builder.Configuration)
    .Build();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();

#if (UseHttpsRedirect)
app.UseHttpsRedirection();
#endif

app.UseUmbraco()
    // .WithMiddleware(u =>
    // {
    //     u.UseBackOffice();
    //     u.UseWebsite();
    // })
    .WithCustomMiddleware(u =>
    {
        u.RunPrePipeline();

        u.UseUmbracoCoreMiddleware();
        u.AppBuilder.UseUmbracoMediaFileProvider();
        u.AppBuilder.UseStaticFiles();
        u.AppBuilder.UseUmbracoPluginsStaticFiles();
        u.AppBuilder.UseRouting();
        // u.AppBuilder.UseCors(MyAllowSpecificOrigins);
        u.AppBuilder.UseAuthentication();
        u.AppBuilder.UseAuthorization();
        u.AppBuilder.UseRequestLocalization();
        u.AppBuilder.UseSession();

        u.RunPreRouting();
        u.RunPostRouting();
        u.RunPostPipeline();
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseInstallerEndpoints();
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
        u.UsePersonalisationGroupsEndpoints();
    });

await app.RunAsync();