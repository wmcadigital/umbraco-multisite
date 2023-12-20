using Wmca.Core.Services;

namespace Wmca
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup" /> class.
        /// </summary>
        /// <param name="webHostEnvironment">The web hosting environment.</param>
        /// <param name="config">The configuration.</param>
        /// <remarks>
        /// Only a few services are possible to be injected here https://github.com/dotnet/aspnetcore/issues/9337.
        /// </remarks>
        public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config)
        {
            _env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940.
        /// </remarks>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins("https://dev-wmca.euwest01.umbraco.io", "https://www.wmca.org.uk")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                    });
            });

            services.AddTransient<ISearchService, SearchService>();

            services.AddUmbraco(_env, _config)
                .AddBackOffice()
                .AddWebsite()
                .AddDeliveryApi()
                .AddComposers()
                .AddMicrosoftAccountAuthentication()
                .AddAzureBlobMediaFileSystem()
                .AddAzureBlobImageSharpCache()
                .Build();
        }

        /// <summary>
        /// Configures the application.
        /// </summary>
        /// <param name="app">The application builder.</param>
        /// <param name="env">The web hosting environment.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseUmbraco()
                .WithCustomMiddleware(u =>
                {
                    u.RunPrePipeline();

                    u.UseUmbracoCoreMiddleware();
                    u.AppBuilder.UseUmbracoMediaFileProvider();
                    u.AppBuilder.UseStaticFiles();
                    u.AppBuilder.UseUmbracoPluginsStaticFiles();
                    u.AppBuilder.UseRouting();
                    u.AppBuilder.UseCors(MyAllowSpecificOrigins);
                    u.AppBuilder.UseAuthentication();
                    u.AppBuilder.UseAuthorization();
                    u.AppBuilder.UseRequestLocalization();
                    u.AppBuilder.UseSession();

                    u.RunPostPipeline();
                    u.UseBackOffice();
                    u.UseWebsite();
                })
                .WithEndpoints(u =>
                {
                    u.UseInstallerEndpoints();
                    u.UseBackOfficeEndpoints();
                    u.UseWebsiteEndpoints();
                });
        }
    }
}