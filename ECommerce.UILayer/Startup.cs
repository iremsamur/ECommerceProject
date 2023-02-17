using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.BusinessLayer.DIContainer;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Handlers.ItemAdsHandlers;
using ECommerce.DataAccessLayer.EntityFramework;
using ECommerce.EntityLayer.Concrete;
using ECommerce.UILayer.Hubs;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UILayer
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

            services.Containerdependencies();

            services.AddAutoMapper(typeof(Startup));
            //services.AddMediatR(typeof(Startup));
            services.CustomizeValidator();
            services.AddSignalR();
            services.AddMediatR(typeof(GetMyOpenItemAdsHandlers).Assembly);
            services.AddHttpContextAccessor();
            //services.AddDbContext<Context>();
            services.AddDbContext<Context>(options=>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
            //token için yukarýdaki yerine bu eklendi
            //services.AddIdentity<AppUser, AppRole>()
            //    .AddEntityFrameworkStores<Context>()
            //    .AddDefaultTokenProviders();
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //    .AddJwtBearer(options =>
            //    {
            //        options.SaveToken = true;
            //        options.RequireHttpsMetadata = false;
            //        options.TokenValidationParameters = new TokenValidationParameters()
            //        {
            //            ValidateIssuer = true,
            //            ValidateAudience = true,
            //            ValidAudience = Configuration["JWT:ValidAudience"],
            //            ValidIssuer = Configuration["JWT:ValidIssuer"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:SecretKey"]))
            //        };
            //    });


            services.AddControllersWithViews().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
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

            app.UseRouting();
            app.UseAuthentication();//bu eklenmezse giriþ yapanýn bilgilerini tutmaz

            app.UseAuthorization();
            

          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chathub");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ItemUI}/{action=GetItemsInTheShowcaseWithImage}/{id?}");
            });
        }
    }
}
