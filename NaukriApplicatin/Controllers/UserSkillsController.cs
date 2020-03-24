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
    public class UserSkillsController : ControllerBase { 
        private UserSkillDomain UserSkillDomain { get; set; }
        public UserSkillsController()
        {
            this.UserSkillDomain = new UserSkillDomain();
        }
        [HttpPost]
        public IActionResult Post(UserSkill userSkill)
        {
            this.UserSkillDomain.Add(userSkill);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var userSkill= this.UserSkillDomain.Get(id);
            return Ok(userSkill);
        }
    }
}
