using Clean.Architecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces
{
    public interface ICourseReponsitory
    {
        IEnumerable<Course> GetCourses();
    }
}
