using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class CourseCenter:IEntity
    {
        public CourseCenter(int courseCenterId, string centerName, string location, int numberOfStudent)
        {
            CourseCenterId = courseCenterId;
            CenterName = centerName;
            Location = location;
            NumberOfStudent = numberOfStudent;
        }
        public int CourseCenterId { get; set; }

        public string CenterName { get; set; }

        public string Location { get; set; }

        public int NumberOfStudent { get; set; }

        public IList<Course>? Courses { get; set; }

        public IList<StudentCourseCenter>? StudentCourseCenters { get; set; }


    }
}
