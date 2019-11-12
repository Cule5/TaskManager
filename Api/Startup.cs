using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Domain.Common;
using Infrastructure;
using Infrastructure.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Services;

namespace Api
{

public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }
        public IContainer Container { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var jwtSetting=new JwtSettings();
            Configuration.GetSection("jwt").Bind(jwtSetting);
            
            services.AddAuthentication().AddJwtBearer((configuration)=>
            {
                
                configuration.TokenValidationParameters=new TokenValidationParameters()
                {
                    ValidIssuer = "http://localhost:51524",
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSetting.SecretKey))
                };
               
            });
            services.AddAuthorization((configuration) =>
            {
                configuration.AddPolicy("CompanyAdmin",r=>
                {
                    r.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
                    r.RequireRole(EUserType.CompanyAdmin.ToString());
                });

                configuration.AddPolicy("ProjectManager", r =>
                {
                    r.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
                    r.RequireRole(EUserType.ProjectManager.ToString());
                });
            });


            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();

            InfrastructureContainer.Build(builder,Configuration);
            ServiceContainer.Build(builder);

            builder.Populate(services);
            Container = builder.Build();

            return new AutofacServiceProvider(Container);
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

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
