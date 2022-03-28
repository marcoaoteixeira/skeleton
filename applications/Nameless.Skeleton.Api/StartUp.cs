using Autofac.Extensions.DependencyInjection;

namespace Nameless.Skeleton.Api {

    public partial class StartUp {

        #region Public Properties

        public IConfiguration Configuration { get; }

        #endregion

        #region Public Constructors

        public StartUp(IConfiguration configuration) {
            Configuration = configuration;
        }

        #endregion

        #region Public Methods

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            ConfigureErrorHandling(services);
            ConfigureAuth(services);
            ConfigureApiVersioning(services);
            ConfigureApi(services);
            ConfigureLocalication(services);
            ConfigureCors(services);
            ConfigureSwagger(services);
            ConfigureConfiguration(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime) {
            UseErrorHandling(app, env);
            UseHttpSecurity(app, env);
            UseEndpoints(app);
            UseAuth(app);
            UseEndpoints(app);
            UseCors(app);
            UseLocalization(app);
            UseSwagger(app, env);

            var container = app.ApplicationServices.GetAutofacRoot();

            // Tear down the composition root and free all resources.
            lifetime.ApplicationStopped.Register(() => container.Dispose());
        }

        #endregion
    }
}
