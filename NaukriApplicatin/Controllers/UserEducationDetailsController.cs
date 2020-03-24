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
    public class UserEducationDetailsController : ControllerBase
    {
        private UserEducationDetailDomain UserEducationDetailDomain{ get; set; }
        public UserEducationDetailsController()
        {
            this.UserEducationDetailDomain= new UserEducationDetailDomain();
        }
        [HttpPost]
        public IActionResult Post(UserEducationDetail userEducationDetail)
        {
            this.UserEducationDetailDomain.Add(userEducationDetail);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var userEducationDetail = this.UserEducationDetailDomain.Get(id);
            return Ok(userEducationDetail);
        }
    }
}
