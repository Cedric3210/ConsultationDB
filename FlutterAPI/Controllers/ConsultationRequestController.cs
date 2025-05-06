using Consultation.Domain;
using Consultation.Infrastructure.Data;
using FlutterAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlutterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultationRequestController: ControllerBase
    {
        private readonly AppDbContext _context;
        public ConsultationRequestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult RequestConsulation([FromBody] Consultation.Domain.ConsultationRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.ConsultationRequest.Add(request); 
            _context.SaveChanges();

            _context.ActionLog.Add(new ActionLog
            {
                ActionLogID = 0,
                Description = "Consultation Request",
                Date = DateTime.Now,
                Time = TimeOnly.FromDateTime(DateTime.Now)
            });
            _context.SaveChanges();

            return Ok(new { message = "Action Successful" });
        }
    }
}
