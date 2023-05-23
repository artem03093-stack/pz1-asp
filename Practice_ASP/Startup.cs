using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Mocks;

namespace Practice_ASP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAppliance, ApplianceMock>();
            services.AddTransient<ICategory, CategoryMock>();
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
        }
    }
}
