using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LogViewer.Web.Data;
using LogViewer.Web.Models;
using Microsoft.AspNetCore.SpaServices.Webpack;
using LogViewer.Web.Hubs;
using LogViewer.BusinessLogic.Interfaces;
using LogViewer.BusinessLogic.Services;

namespace Logviewer.Web
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            services.AddSignalR();
            // Add application services.
            services.AddMvc();
            services.AddTransient<ITfsApi, TfsApiService>();
            services.AddTransient<IOrder, OrderService>();
            services.AddTransient<EmailService>();
            services.AddTransient<ILog, LogService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }



            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseSignalR(routes =>
            {
                routes.MapHub<MessageHub>("message");
            });
            app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}");

                    routes.MapSpaFallbackRoute("spa-fallback", new { controller = "Home", action = "Index" });
                });
        }
    }
}
