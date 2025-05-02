using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyDatabase.Classes
{
    public class Faculty
    {
        public string FacultyName { get; set; }
        public int FacultyID { get; set; }
        public int EnrolledCourseID { get; set; }
        public int FacultyScheduleID { get; set; }

    }
}
