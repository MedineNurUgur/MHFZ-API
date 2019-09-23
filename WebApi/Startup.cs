using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Solution.MhfzDB.Business.Abstract;
using Solution.MhfzDB.Business.Concrete;
using Solution.MhfzDB.DataAccess.Abstract;
using Solution.MhfzDB.DataAccess.Concrete.EntityFramework;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
