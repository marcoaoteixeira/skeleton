namespace Nameless.Skeleton.Api {

    public partial class StartUp {

		#region Public Methods

		public void ConfigureEndpoints(IServiceCollection services) {
			services.AddRouting();
		}

		public void UseEndpoints(IApplicationBuilder app) {
			app.UseRouting();

			app.UseEndpoints(endpoints => {
				endpoints.MapControllerRoute(
					name: "Api",
					pattern: "api/v{version:apiVersion}/{area:exists}/{controller=Value}/{action=Get}/{id?}"
				);
			});
		}

		#endregion
	}
}
