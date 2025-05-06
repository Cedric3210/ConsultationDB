using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlutterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultationShowController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ConsultationShowController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("GetConsultationRequest")]
        public async Task<ActionResult<IEnumerable<ConsultationRequest>>> ShowConsultation(int studentId)
        {
            var result = await _context.ConsultationRequest
            .Include(s => s.Student)
             .Include(s => s.Faculty)
             .Where(s => s.StudentID == studentId)
               .ToListAsync();
            return Ok(result);
        }
    }
}
