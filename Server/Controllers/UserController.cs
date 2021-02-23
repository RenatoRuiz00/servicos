using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Servicos.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login([FromBody] User user)
        {
            /*var result = await _signInManager.PasswordSignInAsync(userInfo.Email,
               userInfo.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return await GenerateTokenAsync(userInfo);
            }
            else
            {
                return BadRequest(new { message = "Login Inválido" });
            }*/
            if (user.Email == "renatoferruiz@hotmail.com" && user.Password == "1234567")
            {
                return new User
                {
                    Email = user.Email,
                    Name = "Renato Fernando Ruiz",
                    Surname = "renatofruiz",
                    TyperUserId = 1
                };
            }
            else
            {
                return BadRequest(new { message = "Login Inválido"});
            }

        }
    }
}
