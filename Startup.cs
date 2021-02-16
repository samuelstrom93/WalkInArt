using DSU21_2.Data;
using DSU21_2.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Google;

namespace DSU21_2
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ArtContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("Grupp2")));
            services.AddScoped<IArtDBRepo, ArtDBRepo>();
            services.AddControllersWithViews();
            //services.AddCors(options =>
            //{
            //    options.AddPolicy(name: MyAllowSpecificOrigins,
            //                      builder =>
            //                      {
            //                          builder.WithOrigins("https://localhost:44373/");
            //                      });
            //});


            //services.AddAuthentication(options =>
            //{
            //    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //})
            //.AddCookie(options =>
            //{
            //    options.LoginPath = "/account/google-login";
            //})
            //.AddGoogle(options =>
            //{
            //    IConfigurationSection googleAuthNSection =
            //    Configuration.GetSection("Authentication:Google");
            //    options.ClientId = googleAuthNSection["ClientId"];
            //    options.ClientSecret = googleAuthNSection["ClientSecret"];
            //});
        }







        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStaticFiles(); // For the wwwroot folder
            app.UseStaticFiles(new StaticFileOptions
            {
                ServeUnknownFileTypes = true,
                DefaultContentType = "image/png"
            });
            app.UseHttpsRedirection();
            app.UseRouting();
            //app.UseCors(MyAllowSpecificOrigins);

            //app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
