using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        void AddInstructor(Instructor instructor);
        void UpdateInstructor(Instructor ınstructor);
        void DeleteInstructor(Instructor ınstructor);
        List<Instructor> GetInstructors();
    }
}
