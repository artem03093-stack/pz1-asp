using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Mocks;

namespace Practice_ASP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var categoryMock = new CategoryMock();
            var applianceMock = new ApplianceMock(categoryMock);

            services.AddSingleton<ICategory>(categoryMock);
            services.AddSingleton<IAppliance>(applianceMock);
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
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
