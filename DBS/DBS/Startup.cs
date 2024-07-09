using DBS.Data;
using DBS.Pages;
using DBS.Services;
using DBS.Shared;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
namespace DBS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;


		}

		public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddScoped<MainLayout>();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<IAlertService, AlertService>();

            services.AddMvc(options =>
            {
                options.InputFormatters.Add(new TextMediaTypeFormatter());
            });
			services.AddSingleton<DataVersionService>();

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
            app.UseRouting();

            #region ���w�n�ϥ� Cookie & �ϥΪ̻{�Ҫ������n��
            app.UseCookiePolicy();
            app.UseAuthentication();
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
            LoadFull();
        }
        public void LoadFull()
        {
            if (ServerData.m_TransactionS.Count <= 0) SQLTemp.LoadTransaction();
            if (ServerData.m_AccountS.Count <= 0) SQLTemp.LoadAccount();
            if (ServerData.m_LogS.Count <= 0) SQLTemp.LoadLog();
            if (ServerData.m_NewAccountS.Count <=0) SQLTemp.LoadNewAccount();
            if (ServerData.m_AccountRepairS.Count <= 0) SQLTemp.LoadAccountRepair();
            if (ServerData.m_NewBankS.Count < -0) SQLTemp.LoadNewBank();
        }
    }
}
