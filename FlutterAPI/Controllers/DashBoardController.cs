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

        [HttpGet("Consulatation/{UpdateStatus}")]
        public IActionResult GetDashBoardData()
        {
           // var count = await _context.Consultations
           //.Where(c => c.StudentId == studentId && c.Status == "Pending")
           //.CountAsync();

           // return Ok(new
           // {
           //     StudentId = studentId,
           //     PendingConsultations = count
           // });
        }

    }
}
