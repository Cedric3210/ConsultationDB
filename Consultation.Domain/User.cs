using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class User
    {
        public int UserID { get; set; }

        public string UserPassword { get; set; }

        public string UserEmail { get; set; }

        public Student student { get; set; }

        public Faculty faculty { get; set; }

    }
}
