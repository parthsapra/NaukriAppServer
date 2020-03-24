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
    public class UserEmploymentDetailController:ControllerBase { 
        private UserEmploymentDetailDomain UserEmploymentDetailDomain { get; set; }
        public UserEmploymentDetailController()
        {
            this.UserEmploymentDetailDomain = new UserEmploymentDetailDomain();
        }
        [HttpPost]
        public IActionResult Post(UserEmploymentDetail userEmploymentDetail)
        {
            this.UserEmploymentDetailDomain.Add(userEmploymentDetail);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var userEmploymentDetail = this.UserEmploymentDetailDomain.Get(id);
            return Ok(userEmploymentDetail);
        }
    }
}
