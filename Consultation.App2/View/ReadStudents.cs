
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
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
            dataGridViewStudents.DataSource = new List<Student>();
            // dataGridViewStudents.AutoGenerateColumns = true;
        }

       // private BindingSource _studentSource = new BindingSource();



        // Mao ni ang View sa tanan students with Read 
        private void buttonShowStudentData_Click(object sender, EventArgs e)
        {
            string searchStudentId = textboxStudentID.Text.Trim();

            using (var studentContext = new AppDbContext())
            {
                IEnumerable<Student> students;
                if (string.IsNullOrWhiteSpace(searchStudentId))
                {
                    // No ID entered: fetch all students
                    students = studentContext.Students.ToList();
                }
                else if(int.TryParse(searchStudentId, out int studentId))
                {
                    // ID entered: fetch matching student(s)
                    students = studentContext.Students
                        .Where(s => s.StudentID.ToString().Contains(searchStudentId))
                        .ToList();
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Student ID.");
                    textboxStudentID.Text = "";
                    return;
                }

                // Optional: use BindingSource
               // _studentSource.DataSource = students;
                dataGridViewStudents.DataSource = students;

            }
        }

        private void ReadStudents_Load(object sender, EventArgs e)
        {

        }

        private void textboxStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
