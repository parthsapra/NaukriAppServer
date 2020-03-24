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
    public class PreviousEmploymentDetailController : ControllerBase { 
        private PreviousEmploymentDetailDomain PreviousEmploymentDetailDomain { get; set; }
        public PreviousEmploymentDetailController()
        {
            this.PreviousEmploymentDetailDomain = new PreviousEmploymentDetailDomain();
        }
        [HttpPost]
        public IActionResult Post(PreviousEmploymentDetail previousEmploymentDetail)
        {
            this.PreviousEmploymentDetailDomain.Add(previousEmploymentDetail);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var previousEmploymentDetail = this.PreviousEmploymentDetailDomain.Get(id);
            return Ok(previousEmploymentDetail);
        }
    }
}
