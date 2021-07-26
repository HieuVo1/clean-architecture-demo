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

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
