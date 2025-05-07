using Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class SchoolYear
    {
        [Key]
        public string SchoolYearID { get; set; }

        public string Term { get; set; }
        public string Semester { get; set; }

        public string Year1 { get; set; }

        public string Year2 { get; set; }

        [ForeignKey(nameof(EnrolledCourseID))]
        public int  EnrolledCourseID { get; set; }
        public SchoolYearStatus SchoolYearStatus { get; set; } 
    }
}
