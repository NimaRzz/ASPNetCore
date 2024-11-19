using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Offices.FacadPattern;
using Project.Domain.Repository.Office;
using Project.Infra.Data.Contexts;
using Project.Infra.Data.Repositories.Office;

namespace Project.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IOfficeFacad, OfficeFacad>();

            //Infra.Data Layer
            services.AddScoped<DataBaseContext>();
            services.AddScoped<IOfficeRepository, OfficeRepository>();
        }
    }
}
