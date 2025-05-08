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

        public TimeOnly StartedTime { get; set; }

        public TimeOnly EndedTime { get; set; }

        public string? DisapprovedReason { get; set; }

        public string SubjectCode { get; set; }

        public Notification Notification { get; set; }

        [ForeignKey(nameof(StudentID))]
        public string StudentID { get; set; } 
        public Student Student { get; set; }

        [ForeignKey(nameof(FacultyID))]
        public string FacultyID { get; set; } 
        public Faculty Faculty { get; set; }
    }
}