using Consultation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class UserApp
    {
        [Key]
        public string UserID { get; set; }

        public string UserPassword { get; set; }

        public string UserEmail { get; set; }

        //public Student Students { get; set; }

        //public Faculty Faculty { get; set; }

        //public UserType UserType { get; set; }

    }
}
