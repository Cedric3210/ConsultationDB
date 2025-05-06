using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
       
    }
}
