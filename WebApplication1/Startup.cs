using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Web;
using UI.Web.Filters;


namespace UI.Web
{
    public class Startup
    {
        IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<DBConnection>(options =>
            {
                options.ConnectionString = @"Data Source=.\SQLExpress;Initial Catalog=Academia;Integrated Security=True";
            });
            //services.AddMemoryCache();  //pendiente ver diferencias
            services.AddDistributedMemoryCache();

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);  //para correr pagina
                //options.IdleTimeout = TimeSpan.FromSeconds(10);    //para pruebas
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.Name = ".Academia.Session";
            });
            services.AddHttpContextAccessor();
            services.AddAuthorization(options=> options.AddPolicy("EstadoReq", policy=> policy.AddRequirements(new EstadoRequerido())));
            services.AddSingleton<IAuthorizationHandler, authFilter>();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Acceso";
                options.LogoutPath = "/Acceso/SessionClose";
            });
            /*services.AddAuthentication(options =>
            {
                //options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                //options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => { options.LoginPath = "/Acceso"; });*/

            services.AddMvc();
            services.AddOptions();
            services.AddTransient<iPlanService, PlanesService>();
            services.AddTransient<ICursosService, CursosService>();
            
           
            services.AddControllersWithViews();

            services.AddRazorPages();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //el orden es importante*
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //ver diferencias con endpoints *
            /*app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });*/
            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();

            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Report}/{action=print}/{id?}");
            });
        }
    }
}
