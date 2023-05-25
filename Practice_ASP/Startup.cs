using Microsoft.EntityFrameworkCore;
using Practice_ASP.Data;
using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Mocks;
using Practice_ASP.Data.Repository;

namespace Practice_ASP
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseMySql(_confString.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 26))));
            //var categoryMock = new CategoryMock();
            //var applianceMock = new ApplianceMock(categoryMock);

            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<IAppliance, ApplianceRepository>();
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
