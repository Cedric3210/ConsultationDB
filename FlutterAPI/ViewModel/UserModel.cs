using Consultation.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace FlutterAPI.ViewModel
{
    public class UserModel
    {
        [Key]
        public string UserID { get; set; }
        public string UserEmail { get; set; }

        public string UserPassword { get; set; }
        public UserType UserType { get; set; }
    }
}
