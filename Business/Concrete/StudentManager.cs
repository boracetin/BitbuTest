using Business.Abstract;
using DataAccess.Abstract;
using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentRepository _studentManager;

        public StudentManager(IStudentRepository studentManager)
        {
            _studentManager = studentManager;
        }
        public Task<Student> Create(Student t)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Student t)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetElemanById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Update(Student t)
        {
            throw new NotImplementedException();
        }
    }
}
