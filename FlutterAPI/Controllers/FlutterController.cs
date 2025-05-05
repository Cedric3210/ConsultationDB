using Microsoft.AspNetCore.Mvc;
using Consultation.Infrastructure.Data;
using Consultation.Domain;
using Microsoft.EntityFrameworkCore;

namespace FlutterAPI.Controllers
{
    //Create an API controller 
    [ApiController]
    [Route("api/[controller]")]
    public class FlutterController : ControllerBase
    {
        private readonly AppDbContext _context;
        public FlutterController(AppDbContext context)
        {
            _context = context;
        }
        
        //This is testing for httpget
        [HttpGet]
        public IActionResult GetUser(int id)
        {
            //Mali ng query
            var user = _context.Students.Include(s => s.StudentName)
                .FirstOrDefault(s => s.StudentID == id);

            if (user == null)
                return NotFound("User not found."); 

            return Ok(user); 
        }
        //This is testing for httpPost 

        [HttpPost]
        public IActionResult CreateUser([FromBody] Student student)
        {
            if (student == null)
                return BadRequest("Invalid user data.");
            _context.Students.Add(student);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUser), new { id = student.ProgramID }, student);
        }
    }
}
