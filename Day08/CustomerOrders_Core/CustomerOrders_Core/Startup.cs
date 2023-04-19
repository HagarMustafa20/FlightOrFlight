using Microsoft.EntityFrameworkCore;
using CustomerOrders_Core.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CustomerOrders_Core.Data;
using System.Net;

namespace CustomerOrders_Core
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment WebHost { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment webHost)
        {
            Configuration = configuration;
            WebHost = webHost;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();  //Enable MVC Service "Contained"  
            services.AddDbContext<StudentContext>(options =>
                  //op.UseSqlServer("Data Source=.;Initial Catalog=ProductsDb_43;Integrated Security=True")
                  //op.UseSqlServer(Configuration["ConnectionStrings:myConn"])
                  options.UseSqlServer(Configuration.GetConnectionString("Con"))
              );

            services.AddDbContext<CustomerOrders_CoreContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CustomerOrders_CoreContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            //app.UseMvcWithDefaultRoute();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
              (
                  name: "myOwnRoute",
                  pattern: "{Controller=Students}/{Action=Index}/{id?}"
              );
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
        }
    }
}
