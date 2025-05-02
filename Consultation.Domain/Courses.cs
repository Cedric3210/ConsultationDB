using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }

        public string CourseName { get; set; }

        public string  CourseTitle { get; set; }

        public string Description { get; set; }

        [ForeignKey(nameof(ProgramID))]
        public int ProgramID { get; set; }
    }
}
