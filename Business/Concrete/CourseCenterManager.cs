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
    public class CourseCenterManager : ICourseCenterService
    {
        private ICourseCenterRepository _courseCenterManager;
        public CourseCenterManager(ICourseCenterRepository courseCenterManager)
        {
            _courseCenterManager = courseCenterManager;
        }

        public Task<CourseCenter> Create(CourseCenter t)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CourseCenter t)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseCenter>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CourseCenter> GetElemanById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseCenter> Update(CourseCenter t)
        {
            throw new NotImplementedException();
        }
    }
}
