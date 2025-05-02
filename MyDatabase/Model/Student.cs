using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Model
{
    public class Student
    {
        public string FullName { get; set; }
        public int StudentID { get; set; }
        public string Program { get; set; }
        public string Email { get; set; }
        public List<string> EnrolledCourses { get; set; }
    }
}
