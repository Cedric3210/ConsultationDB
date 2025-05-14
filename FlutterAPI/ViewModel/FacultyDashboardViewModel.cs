using Consultation.Domain;

namespace FlutterAPI.ViewModel
{
    public class FacultyDashboardViewModel
    {
        public Student Student { get; set; }

        public EnrolledCourse EnrolledCourse { get; set; }

        public string ConsultationSchedule { get; set; }

        public ConsultationRequest ConsultationRequest { get; set; }

    }
}
