using Definux.Emeraude.Admin.ClientBuilder.Extensions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Extensions;
using Emeraude.Template.Application.Interfaces.Persistence;
using Emeraude.Template.Application.Mapping;
using Emeraude.Template.Infrastructure.Extensions;
using Emeraude.Template.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Template
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEmeraude<IEntityContext, EntityContext>(options =>
            {
                options.ApplyEmeraudeBaseOptions();

                options.DatabaseContextProvider = DatabaseContextProvider.PostgreSql;
                options.MigrationsAssembly = "Emeraude.Template.Infrastructure";
                options.ExecuteMigrations = true;

                options.Mapping.AddProfile<MainAssemblyMappingProfile>();
                options.AddAssembly("Emeraude.Template");
                options.AddAssembly("Emeraude.Template.Application");
                options.ProjectName = "Emeraude.Template";
            });

            services.AddEmeraudeClientBuilder(options =>
            {
                options.SetWebAppPath("web", "Emeraude.Template", "ClientApp");
                options.SetMobileAppPath("mobile", "Emeraude.Template.Mobile");

                options.AddAssembly("Definux.Emeraude");
                options.AddAssembly("Emeraude.Template");

                options.AddDefaultVueModules();
            });

            services.RegisterInfrastructureServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEmeraude(env);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
