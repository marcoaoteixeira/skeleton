namespace Nameless.Skeleton.Api {

    public partial class StartUp {

        #region Public Methods

        public void UseAuth(IApplicationBuilder app) {
            app.UseAuthentication();
            app.UseAuthorization();
        }

        public void ConfigureAuth(IServiceCollection services) {
        }

        #endregion
    }
}
