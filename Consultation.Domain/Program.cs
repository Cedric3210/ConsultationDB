using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Consultation.Domain
{
    public class Program
    {
        public string  ProgramName { get; set; }

        public string Description { get; set; }

        [ForeignKey(nameof(DepartmentID))]
        public int  DepartmentID { get; set; }
        [Key]
        public int ProgramID { get; set; }
    }
}
