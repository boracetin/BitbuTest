using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Course:IEntity
    {

        public Course(int courseId, string courseName, string url, byte[] image, string book, string pdf)
        {
            CourseId = courseId;
            CourseName = courseName;
            Url = url;
            Image = image;
            Book = book;
            Pdf = pdf;
        }

        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string Url { get; set; }

        public byte[] Image { get; set; }

        public string Book { get; set; }


        public string Pdf { get; set; }

        public IEnumerable<StudentCourse>? StudentCourses { get; set; }

        public CourseCenter? CourseCenter { get; set; }





    }
}
