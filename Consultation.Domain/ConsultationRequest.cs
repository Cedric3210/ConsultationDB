using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultation.Domain.Enum;

namespace Consultation.Domain
{
    public class ConsultationRequest
    {
        [Key]
        public int ConsultationID { get; set; }

        public DateTime DateSchedule { get; set; }

        public string Concern { get; set; }

        public DateTime DateRequested { get; set; }

        public Status Status { get; set; }

        public string? DisapprovedReason { get; set; }

        public string SubjectCode { get; set; } 

        //This is suppose to be a Reference Type 
        //Code: Public Notification Notification { get; set; }
        public string Notify { get; set; } //???

        [ForeignKey(nameof(StudentID))]
        public int StudentID { get; set; } 
        public Student Student { get; set; }

        [ForeignKey(nameof(FacultyID))]
        public int FacultyID { get; set; } 
        public Faculty Faculty { get; set; }
    }
}