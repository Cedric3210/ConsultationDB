

using DatabaseRecorder;

//Console.WriteLine("Enter Faculty name: ");
//string FacultyName = Console.ReadLine();
Console.WriteLine("Enter Faculty ID: ");
int autoIncrement = Convert.ToInt32(Console.ReadLine());

Faculty.deleteFaculty(autoIncrement);