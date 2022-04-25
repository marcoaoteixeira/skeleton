using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace Nameless.Skeleton.Api {

    public partial class StartUp {

        #region Public Methods

        public void ConfigureLocalication(IServiceCollection services) {
            // TODO: Add localization configuration
        }

        public void UseLocalization(IApplicationBuilder app) {
            var supportedCultures = new[] {
                new CultureInfo ("pt-BR"),
                new CultureInfo ("en-US")
            };
            app.UseRequestLocalization(new RequestLocalizationOptions {
                DefaultRequestCulture = new RequestCulture("pt-BR"),
                // Formatting numbers, dates, etc.
                SupportedCultures = supportedCultures,
                // UI strings that we have localized.
                SupportedUICultures = supportedCultures
            });
        }

        #endregion
    }
}
