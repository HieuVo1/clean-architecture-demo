using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Domain.Models;
using Clean.Architecture.Infastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infastructure.Data.Repository
{
    public class CourseRepository : ICourseReponsitory
    {
        private readonly UniversityDBContext _universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;
        }

        public void Add(Course course)
        {
            _universityDBContext.Courses.Add(course);
            _universityDBContext.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }
    }
}
