using Clean.Architecture.Application.Interfaces;
using Clean.Architecture.Application.Services;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Infastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infastructure Layer
            services.AddScoped<ICourseReponsitory, CourseRepository>();
        }
    }
}
