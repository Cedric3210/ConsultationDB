using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Faculty
    {
        [Key]
        public string FacultyID { get; set; }
        public int FacultyNumber { get; set; }
        public string FacultyName { get; set; }

        [ForeignKey(nameof(EnrolledCourseID))]
        public int EnrolledCourseID { get; set; }
        public virtual EnrolledCourse EnrolledCourse { get; set; }

        [ForeignKey(nameof(FacultyScheduleID))]
        public int FacultyScheduleID { get; set; }
        public virtual FacultySchedule FacultySchedule { get; set; }

        //Added this field kay and faculty diba naa list of pila ka request na abot sa ilaha
        //Pero dili pako siure If needed jud siya
        //public List<ConsultationRequest> ConsultationRequests { get; set; }
    }
}
