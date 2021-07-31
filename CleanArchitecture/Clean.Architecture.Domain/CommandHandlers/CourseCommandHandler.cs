using Clean.Architecture.Domain.Commands;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseReponsitory _courseReponsitory;

        public CourseCommandHandler(ICourseReponsitory courseReponsitory)
        {
            _courseReponsitory = courseReponsitory;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            _courseReponsitory.Add(course);
            return Task.FromResult(true);
        }
    }
}
