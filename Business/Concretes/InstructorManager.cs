using Business.Abstracts;
using Entities.Concretes;
using System;
using DataAcces.Abstracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {

        IInstructorDal _instructorDal;

        public void AddInstructor(Instructor instructor)
        {
            _instructorDal.AddInstructor(instructor);
        }

        public void DeleteInstructor(Instructor instructor)
        {
            _instructorDal.DeleteInstructor(instructor);
        }

        public List<Instructor> GetInstructors()
        {
            return _instructorDal.GetAllInstructors();
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _instructorDal.UpdateInstructor(instructor);
        }
    }
}
