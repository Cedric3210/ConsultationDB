﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class EnrolledCourse
    {
        [Key]
        public string EnrolledCourseID { get; set; }

        public string Code { get; set; }

        [ForeignKey(nameof(CourseID))]
        public int CourseID { get; set; }
    }
}
