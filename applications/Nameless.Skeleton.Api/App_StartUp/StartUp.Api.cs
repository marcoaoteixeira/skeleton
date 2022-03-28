namespace Nameless.Skeleton.Api {

    public partial class StartUp {

        #region Public Methods

        public void ConfigureApi(IServiceCollection services) {
            services.AddControllers();
        }

        #endregion
    }
}
