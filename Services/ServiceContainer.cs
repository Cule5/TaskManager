using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;

namespace Services
{
    public static class ServiceContainer
    {
        public static void Build(ContainerBuilder containerBuilder)
        {
            var servicesAssembly = Assembly.GetExecutingAssembly();
            var coreAssembly = Assembly.GetAssembly(typeof(Core.Domain.User.User));
            containerBuilder.RegisterAssemblyTypes(servicesAssembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            containerBuilder.RegisterAssemblyTypes(coreAssembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

        }
    }
}
