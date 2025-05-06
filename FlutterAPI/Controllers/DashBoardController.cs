using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace FlutterAPI.Controllers
{
    public class DashBoardController : ControllerBase
    {
        private readonly AppDbContext _context;
        public DashBoardController(AppDbContext context)
        {
            _context = context;
        }



    }
}
