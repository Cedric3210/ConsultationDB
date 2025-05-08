
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App2.View
{
    public partial class ReadStudents : Form
    {

        public ReadStudents()
        {
            InitializeComponent();

            // dataGridViewStudents.DataSource = new List<Student>();
            // dataGridViewStudents.AutoGenerateColumns = true;
        }

        // private BindingSource _studentSource = new BindingSource();



        // Mao ni ang View sa tanan students with Read 
        private void buttonShowStudentData_Click(object sender, EventArgs e)
        {
            string searchStudentId = textboxStudentID.Text.Trim();

            using (var studentContext = new AppDbContext())
            {
                var students1 = studentContext.Students
                         .Select(s => new StudentDto
                         {
                             StudentName = s.StudentName,
                             StudentID = s.StudentID,
                             Email = s.Email,
                         })
                         .ToList();

                if (searchStudentId != null)
                {
                    students1 = students1
                        .Where(s => s.StudentID.ToString() == searchStudentId || s.StudentName.Contains(searchStudentId))
                        .ToList();
                }

                dataGridViewStudents.DataSource = students1;


            }
        }

        private void ReadStudents_Load(object sender, EventArgs e)
        {

        }

        private void textboxStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowStudentCourse_Click(object sender, EventArgs e)
        {

        }
    }

    // prototype for the button shown student data model (buttons)
    public class StudentDto
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
    }
}
