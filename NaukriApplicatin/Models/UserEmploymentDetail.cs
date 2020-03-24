using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaukriApplicatin.Models
{
    public class UserEmploymentDetail
    {
        public int UserEmploymentDetailId { get; set; }
        public int UserId { get; set; } 
        public string Designation { get; set; }
        public string CompanyName { get; set; } 
        public string SalaryLakhs { get; set; }
        public string SalaryThousands { get; set; }
        public int StartYear { get; set; }
        public string StartMonth { get; set; }
        public int EndYear { get; set; }
        public string EndMonth { get; set; }
        public string City { get; set; }
        public string NoticPeriod { get; set; }
        public string Industry { get; set; }
        public string FunctionalArea { get; set; }
        public string Role { get; set; }
    }
}