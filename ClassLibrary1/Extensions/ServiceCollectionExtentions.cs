using Microsoft.Extensions.DependencyInjection;
using PetShelter.Shared.Atributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Extensions
{
    public static class ServiceCollectionExtentions
    {
        public static void AutoBind(this IServiceCollection source, params Assembly[] assemblies)
        {
            source.Scan(scan => scan.FromAssemblies(assemblies)
            .AddClasses(classes => classes.WithAttribute<AutoBind>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            
        }
    }
}
