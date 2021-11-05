using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreService.Base
{
    public static class ServiceRegistery
    {
        public static void RegisterService(this IServiceCollection services, Assembly assembly = null)
        {
            if (assembly == null)
                assembly = Assembly.GetExecutingAssembly();

            var allScopedIService = assembly.ExportedTypes.Where(p => p.IsInterface && p.GetInterface(nameof(IScopedDependency)) != null);
            var allScopedService = assembly.ExportedTypes.Where(p => p.IsClass && p.GetInterface(nameof(IScopedDependency)) != null);

            var allTransienIService = assembly.ExportedTypes.Where(p => p.IsInterface && p.GetInterface(nameof(ITransientDependency)) != null);
            var allTransienService = assembly.ExportedTypes.Where(p => p.IsClass && p.GetInterface(nameof(ITransientDependency)) != null);

            var allSingletIService = assembly.ExportedTypes.Where(p => p.IsInterface && p.GetInterface(nameof(ISingletonDependency)) != null);
            var allSingletService = assembly.ExportedTypes.Where(p => p.IsClass && p.GetInterface(nameof(ISingletonDependency)) != null);

            foreach (var interfaceType in allScopedIService)
            {
                Type implementationType = allScopedService.FirstOrDefault(p => p.GetInterface(interfaceType.Name) != null);
                if (implementationType != null)
                    services.AddScoped(interfaceType, implementationType);
            }

            foreach (var interfaceType in allTransienIService)
            {
                Type implementationType = allTransienService.FirstOrDefault(p => p.GetInterface(interfaceType.Name) != null);
                if (implementationType != null)
                    services.AddTransient(interfaceType, implementationType);
            }

            foreach (var interfaceType in allSingletIService)
            {
                Type implementationType = allSingletService.FirstOrDefault(p => p.GetInterface(interfaceType.Name) != null);
                if (implementationType != null)
                    services.AddSingleton(interfaceType, implementationType);
            }

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
