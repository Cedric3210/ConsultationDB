using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class Notification
    {
        //Kani lang akuang gi add kay mao lang ma isip nako ron

        [Key]
        public int NotificationNumber { get; set; }

        public string NotificationMessage { get; set; }
    }
}
