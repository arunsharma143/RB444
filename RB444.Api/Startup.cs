using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RB444.Core.IServices;
using RB444.Core.IServices.BetfairApi;
using RB444.Core.Services;
using RB444.Core.Services.BetfairApi;
using RB444.Data.Entities;
using RB444.Data.Infrastructure;
using RB444.Data.JwtAuth;
using RB444.Data.Repository;
using RB444.Data.UOW;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RB444.Api
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
            services.AddControllers();

            services.AddTransient<IUserStore<Users>, UserStore>();
            services.AddTransient<IRoleStore<ApplicationRole>, RoleStore>();

            services.AddIdentity<Users, ApplicationRole>()
               .AddDefaultTokenProviders();

            var key = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key))
                };
            });

            services.AddSingleton<IJwtAuth>(new Auth(key));

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v2", new OpenApiInfo
                {
                    Title = "Place Info Service API",
                    Version = "v2",
                    Description = "Sample service for Learner",
                });
            });

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowAll",
            //        builder => builder.AllowAnyOrigin()
            //                            .AllowAnyHeader()
            //                            .AllowAnyMethod());
            //});

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowMyOrigin",
            //    builder => builder.WithOrigins(
            //        "http://api.rb444.in/",
            //        "https://localhost:44390/")
            //        .WithMethods("POST", "GET", "PUT")
            //        .WithHeaders("*")
            //        );
            //});

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            services.AddHttpContextAccessor();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddTransient<IDatabase, Database>();

            services.AddTransient<IBetfairApiServices, BetfairApiServices>();
            services.AddTransient<IExchangeService, ExchangeService>();
            services.AddTransient<ICommonService, CommonService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IBetApiService, BetApiService>();
            services.AddTransient<IOtherSetting, OtherSetting>();
            services.AddTransient<ISettingService, SettingService>();
            services.AddTransient<IMarketWatchService, MarketWatchService>();
            services.AddTransient<IRequestServices, RequestServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseHttpsRedirection();

            app.UseRouting();            

            app.UseAuthentication();
            app.UseAuthorization();

            var supportedCultures = new List<CultureInfo> { };
            var en = new CultureInfo("en-US");
            en.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy HH:mm:ss";
            en.DateTimeFormat.DateSeparator = "/";
            supportedCultures.Add(en);

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                // Formatting numbers, dates, etc.
                SupportedCultures = supportedCultures,
                // UI strings that we have localized.
                SupportedUICultures = supportedCultures,
            });
            app.Use(async (context, next) =>
            {
                context.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("en-US"))
            );
                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v2/swagger.json", "PlaceInfo Services"));
        }
    }
}
