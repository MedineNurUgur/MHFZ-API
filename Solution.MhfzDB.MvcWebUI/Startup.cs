using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.Business.Concrete;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.DataAccess.Concrete.EntityFramework;
using Solution.MhfzDB.MvcWebUI.Middlewares;

namespace Solution.MhfzDB.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyManager>();
            services.AddScoped<ICompanyDal, EfCompanyDal>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();
            services.AddScoped<IExpertService, ExpertManager>();
            services.AddScoped<IExpertDal, EfExpertDal>();
            services.AddScoped<IInventoryService, InventoryManager>();
            services.AddScoped<IInventoryDal, EfInventoryDal>();
            services.AddScoped<IInventory_StateService, Inventory_StateManager>();
            services.AddScoped<IInventory_StateDal, EfInventory_StateDal>();
            services.AddScoped<IWorksiteService, WorksiteManager>();
            services.AddScoped<IWorksiteDal, EfWorksiteDal>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Company}/{action=Index}/{id?}"
                    );
            });
            app.UseStaticFiles();
        }
    }
}
