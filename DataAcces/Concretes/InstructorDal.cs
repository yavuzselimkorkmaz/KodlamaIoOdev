using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes
{
    internal class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>();
            _instructors.Add(new Instructor {InstructorId=1,InstructorFirstName="Engin",InstructorLastName="Demiroğ" });
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void DeleteInstructor(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructors;
        }

        public void UpdateInstructor(Instructor instructor)
        {
            Console.WriteLine(instructor.InstructorFirstName+" Güncellendi");
        }
    }
}
