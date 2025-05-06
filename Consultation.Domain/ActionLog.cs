using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class ActionLog
    {
        [Key]
        public int ActionLogID { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public TimeOnly Time { get; set; }

        [ForeignKey(nameof(UserID))]
        public int UserID { get; set; }
    }
}
