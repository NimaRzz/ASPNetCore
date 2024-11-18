using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Project.Infra.Data.Contexts;

namespace Project.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer


            //Infra.Data Layer
            services.AddScoped<DataBaseContext>();
        }
    }
}
