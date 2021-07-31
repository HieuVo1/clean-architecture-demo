using Clean.Architecture.Application.Interfaces;
using Clean.Architecture.Application.ViewModels;
using Clean.Architecture.Domain.Commands;
using Clean.Architecture.Domain.Core.Bus;
using Clean.Architecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseReponsitory _courseReponsitory;
        private readonly ImediatorHandler _bus;

        public CourseService(ICourseReponsitory courseReponsitory, ImediatorHandler bus)
        {
            _courseReponsitory = courseReponsitory;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);
            _bus.SendCommand<CreateCourseCommand>(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseReponsitory.GetCourses()
            };
        }
    }
}
