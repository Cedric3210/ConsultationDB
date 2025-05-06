using Consultation.Domain;
using Enum;

namespace FlutterAPI.DTO
{
    public class User
    {
        public Student student { get; set; }

        public Faculty faculty { get; set; }

        //public Admin admin { get; set; }

        public string UserPassword22 { get; set; }

        public string UserEmail { get; set; }

        public UserType UserType { get; set; }
    }
}
