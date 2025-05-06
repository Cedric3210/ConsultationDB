using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Isid
    {
        [Key]
        public int IsidId { get; set; }
        public string IsidName { get; set; }
    }
}
