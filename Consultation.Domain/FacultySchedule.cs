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
    public class FacultySchedule
    {
        [Key]
        public int FacultyScheduleID { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

        public DaysOfWeek Day { get; set; }
    }
}
