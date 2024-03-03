using Business.Abstracts;
using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal; 

        public void AddCourse(Course course)
        {
            _courseDal.AddCourse(course);
        }

        public List<Course> GetCourses()
        {
            return _courseDal.ListCourses();
        }

        public void RemoveCourse(Course course)
        {
            _courseDal.DeleteCourse(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.UpdateCourse(course);
        }
    }
}
