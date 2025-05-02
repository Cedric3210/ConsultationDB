using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Model
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectID { get; set; }
        public int SubjectFacultyID{ get; set; }
        public int SubjectScheduleID { get; set; }

    }
}
