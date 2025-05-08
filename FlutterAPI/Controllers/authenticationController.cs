using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using FlutterAPI.ViewModel;

namespace FlutterAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthenticationController(AppDbContext context)
        {
            _context = context;
        }

        //Register Controller
        [HttpPost]
        public async Task<IActionResult> RegisterPerson([FromBody] UserModel Users)
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
                UserEmail = Users.UserEmail,
                UserID = Users.UserID,
            };

            _context.ActionLog.Add(new ActionLog
            {
                ActionLogID = 0,
                Description = "Account has been Added",
                Date = DateTime.Now,
                Time = TimeOnly.FromDateTime(DateTime.Now)
            });

            _context.Users.Add(student);
            await _context.SaveChangesAsync();

            return Ok("Registration successful");
        }

        //Log-in Controller
        [HttpPost]
        public IActionResult Login([FromBody] UserModel Users)
        {

            if (Users == null || string.IsNullOrEmpty(Users.UserEmail) || string.IsNullOrEmpty(Users.UserPassword))
                return BadRequest("Username and password are required.");

            var user = _context.Users.FirstOrDefault(u => u.UserEmail == Users.UserEmail);

            if (!IsValidUser(Users.UserEmail, Users.UserPassword))
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
                username = user.UserEmail
            });
        }

        //This query is used to check if the user is valid
        private bool IsValidUser(string username, string password)
        {
            var userValid = _context.Users.FirstOrDefault(u => u.UserEmail == username);
            return userValid != null && userValid.UserPassword == password;
        }
    }
}
