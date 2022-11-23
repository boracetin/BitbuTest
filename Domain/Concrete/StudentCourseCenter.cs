using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class StudentCourseCenter
    {

        public int Id { get; set; }

        public int CourseCenterId { get; set; }

        public CourseCenter? CourseCenter { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
