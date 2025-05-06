using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Admin
    {
        [Key]
        public int AdminID {  get; set; }
        
        public string AdminUsername { get; set; }

        [ForeignKey(nameof(UserID))]
        public int UserID { get; set; }
    }
}
