﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class StudentCourse
    {

        public int Id { get; set; }

        public int CourseId { get; set; }

        public Course? Course { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }

    }
}
