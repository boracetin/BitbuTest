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
    public class CourseManager : ICourseService
    {
        private ICourseRepository _courseManager;
        public CourseManager(ICourseRepository courseManager)
        {
            _courseManager = courseManager;
        }

        public Task<Course> Create(Course t)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Course t)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetElemanById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> Update(Course t)
        {
            throw new NotImplementedException();
        }
    }
}
