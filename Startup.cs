using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using In_Class_API_Consumption.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace In_Class_API_Consumption
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
			services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:datagovapi:ConnectionString"]));

			services.AddMvc(options => options.EnableEndpointRouting = false);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				//app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
            endpoints.MapDefaultControllerRoute();                
            });

			app.UseMvc(routes =>
			{
				routes.MapRoute(
				name: "default",
				template: "{controller=Home}/{action=Index}/{id?}");
				// Call Services page 
				routes.MapRoute(
				name: "services",
				template: "{controller=Home}/{action=Services}");

			}
			);

		}
	}
}
