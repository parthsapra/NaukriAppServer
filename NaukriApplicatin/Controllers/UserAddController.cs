using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NaukriApplicatin.Domains;
using NaukriApplicatin.Models;

namespace NaukriApplicatin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserAddController : ControllerBase
    {
        private UserDomain UserDomain { get; set; }
        public UserAddController()
        {
            this.UserDomain = new UserDomain();
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            this.UserDomain.UserAdd(user);
            return Ok();
        }
    }
}
