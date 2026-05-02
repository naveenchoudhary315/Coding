using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AuthenticationDemo.JWTImplementation
{
    internal class JWTController : ApiController
    {
        private readonly JwtService _jwtService;

        public JWTController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost()]
        public IActionResult Login(string username, string password)
        {
            // validate user (DB check)
            if (username == "admin" && password == "123")
            {
                var token = _jwtService.GenerateToken(username);
                return (IActionResult)Ok(new { token });
            }

            return (IActionResult)Unauthorized();
        }

        [Authorize]
        [HttpGet()]
        public IActionResult GetSecureData()
        {
            return (IActionResult)Ok("This is protected data");
        }
    }
}
