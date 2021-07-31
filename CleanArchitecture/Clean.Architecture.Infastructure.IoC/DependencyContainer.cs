using Clean.Architecture.Application.Interfaces;
using Clean.Architecture.Application.Services;
using Clean.Architecture.Domain.CommandHandlers;
using Clean.Architecture.Domain.Commands;
using Clean.Architecture.Domain.Core.Bus;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Infastructure.Bus;
using Clean.Architecture.Infastructure.Data.Context;
using Clean.Architecture.Infastructure.Data.Repository;
using MediatR;
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
            //Domain InMemoryBus MediatR
            services.AddScoped<ImediatorHandler, InMemoryBus>();

            //Domain Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            //Application Layer 
            services.AddScoped<ICourseService, CourseService>();

            //Infastructure Layer
            services.AddScoped<ICourseReponsitory, CourseRepository>();
            services.AddScoped<UniversityDBContext>();
        }
    }
}
