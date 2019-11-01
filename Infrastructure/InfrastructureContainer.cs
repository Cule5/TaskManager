using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Infrastructure.Authentication;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public static class InfrastructureContainer
    {
        
        public static void Build(ContainerBuilder containerBuilder,IConfiguration configuration)
        {
            var infrastructureAssembly = Assembly.GetExecutingAssembly();
            containerBuilder.RegisterAssemblyTypes(infrastructureAssembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            containerBuilder.RegisterType<AppDbContext>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<JwtProvider>().As<IJwtProvider>().SingleInstance();
            var jwtSettings=new JwtSettings();
            configuration.GetSection("jwt").Bind(jwtSettings);
            containerBuilder.RegisterInstance(jwtSettings);
        }
    }
}
