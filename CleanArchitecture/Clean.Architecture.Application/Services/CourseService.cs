using Clean.Architecture.Application.Interfaces;
using Clean.Architecture.Application.ViewModels;
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

        public CourseService(ICourseReponsitory courseReponsitory)
        {
            _courseReponsitory = courseReponsitory;
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
