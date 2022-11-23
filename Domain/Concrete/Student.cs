using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Student:IEntity
    {


        public Student(int studentId, string name, int nationalNumber, DateTime birthDay)
        {
            StudentId = studentId;
            Name = name;
            NationalNumber = nationalNumber;
            BirthDay = birthDay;
        }

        public int StudentId { get; set; }

        public string Name { get; set; }

        public int NationalNumber { get; set; }
       
        public DateTime BirthDay { get; set; }


        public IEnumerable<StudentCourse>? StudentCourses { get; set; }

        public IEnumerable<StudentCourseCenter>? StudentCourseCenters { get; set; }

       
    }
}
