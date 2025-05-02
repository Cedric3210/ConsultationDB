using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DatabaseRecorder
{
    public class Faculty
    {
        public string FacultyName { get; set; }
        public int FacultyID { get; set; }
        public int EnrolledCourseID { get; set; }
        public int FacultyScheduleID { get; set; }

   
        public static void AddFaculty(string facultyname,int autoIncrement)
        {
            var FacultyDatabase = new Dictionary<string, Faculty>();
           

            var Faculty = new Faculty()
            {
                FacultyName = facultyname,
                FacultyID = autoIncrement,
                FacultyScheduleID = 0,
                EnrolledCourseID = 0,
            };

            FacultyDatabase.Add($"Faculty{autoIncrement:D3}", Faculty);

            var output = new Dictionary<string, object>()
            {
                {"Faculty", FacultyDatabase}
            };

            string json = System.Text.Json.JsonSerializer.Serialize(output, new JsonSerializerOptions { WriteIndented = true });

            string path = "FacultyDatabase.json";
            System.IO.File.WriteAllText("facultyData.json", json);

            Console.WriteLine($"\n JSON saved to {Path.GetFullPath(path)}");

        }

        //Create a function that deletes a faculty member from the dictionary
        public static void deleteFaculty(int FacultyID)
        {
            var facultyTable = new Dictionary<string, Faculty>();
            if (facultyTable.ContainsKey(FacultyID.ToString()))
            {
                facultyTable.Remove(FacultyID.ToString());
                Console.WriteLine($"Faculty {FacultyID} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Faculty {FacultyID} not found.");
            }
        }

        public static void SearchFaculty()
        {
            
        }
    }
}
