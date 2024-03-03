using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>();
            _courses.Add(new Course {CourseId=1,CourseName="c# kursu",CourseDescription="2 aylık c# kampı" });
            _courses.Add(new Course { CourseId = 2, CourseName = "java kursu", CourseDescription = "2 aylık java kampı" });
            _courses.Add(new Course { CourseId = 3, CourseName = "python kursu", CourseDescription = "2 aylık python kampı" });
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public void DeleteCourse(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> ListCourses()
        {
            return _courses;   
        }

        public void UpdateCourse(Course course)
        {
            Console.WriteLine(course.CourseName+" Güncellendi!");
        }
    }
}
