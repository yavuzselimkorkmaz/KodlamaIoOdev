using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        void RemoveCourse(Course course);
        void UpdateCourse(Course course);
        List<Course> GetCourses();
    }
}
