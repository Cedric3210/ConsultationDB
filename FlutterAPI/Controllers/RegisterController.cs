using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlutterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegisterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("RegisterPerson")]
        public async Task<IActionResult> RegisterPerson([FromBody] Users Users)
        {
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.UserEmail == Users.UserEmail);

            if (existingUser != null)
            {
                return BadRequest("Account has been Register");
            }

            var student = new Users
            {
                UserPassword = Users.UserPassword,
                UserEmail = Users.UserEmail
            };

            _context.ActionLog.Add(new ActionLog
            {
                ActionLogID = 0,
                Description = "Account has been Added",
                Date = DateTime.Now,
                Time = TimeOnly.FromDateTime(DateTime.Now)
            });

            //_context.SaveChanges();
            //_context.SaveChanges();
            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return Ok("Registration successful");
        }

    }
}
