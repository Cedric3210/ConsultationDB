using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace FlutterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginControllercs : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoginControllercs(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            //Get the user
            var user = _context.Users.FirstOrDefault(u => u.UserEmail == request.Email);

            if (request == null || string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
                return BadRequest("Username and password are required.");

            if (request == null || user.UserPassword != request.Password)
                return Unauthorized("Wrong Email and Password.");

            _context.ActionLog.Add(new ActionLog
            {
                ActionLogID = 0,
                Description = "Login",
                Date = DateTime.Now,
                Time = TimeOnly.FromDateTime(DateTime.Now)
            });
            _context.SaveChanges();

            return Ok(new
                    {
                message = "Login successful",
                userId = user.UserID,
                username = user.UserEmail
                 }); 
        }
    }
     
}
