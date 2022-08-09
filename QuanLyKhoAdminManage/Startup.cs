using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.System.Users;
using System;
using Microsoft.AspNetCore.Http;
using JavaScriptEngineSwitcher.V8;
using React.AspNet;

namespace QuanLyKhoAdminManage
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
            services.AddDbContext<QuanLyKhoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("QuanLyKho")));
            services.AddControllersWithViews();
            services.AddHttpClient();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
            {
                option.LoginPath = "/Login/Index";
                option.AccessDeniedPath = "/Login/Forbidden/";

            });
           
            services.AddControllersWithViews()
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>());
            services.AddSession(
                opt =>
                {
                    opt.IdleTimeout = TimeSpan.FromMinutes(30);
                });
            services.AddTransient<IUserApiClient, UserApiClient>();
            services.AddTransient<IProductApiClient, ProductApiClient>();
            services.AddTransient<IDebtApiServices, DebtApiServices>();
            services.AddTransient<IEmpApiServices, EmpApiServices>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();

            // Make sure a JS engine is registered, or you will get an error!
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = V8JsEngine.EngineName)
              .AddV8();
           
            IMvcBuilder builder = services.AddRazorPages();
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            #if DEBUG
                if (enviroment == Environments.Development)
	            {
                     builder.AddRazorRuntimeCompilation();
	            }
            #endif
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            // Initialise ReactJS.NET. Must be before static files.
            app.UseReact(config =>
            {
                // If you want to use server-side rendering of React components,
                // add all the necessary JavaScript files here. This includes
                // your components as well as all of their dependencies.
                // See http://reactjs.net/ for more information. Example:
                //config
                //  .AddScript("~/js/First.jsx")
                //  .AddScript("~/js/Second.jsx");

                // If you use an external build too (for example, Babel, Webpack,
                // Browserify or Gulp), you can improve performance by disabling
                // ReactJS.NET's version of Babel and loading the pre-transpiled
                // scripts. Example:
                //config
                //  .SetLoadBabel(false)
                //  .AddScriptWithoutTransform("~/js/bundle.server.js");
            });
            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute("default", "{controller}/{action}/{id?}");
                endpoints.MapDefaultControllerRoute();

            });
        }
    }
}
