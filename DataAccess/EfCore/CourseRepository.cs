using DataAccess.Abstract;
using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EfCore
{
    public class CourseRepository:EfCoreGenericRepository<Course,ConionProjectContext>,ICourseRepository
    {
    }
}
