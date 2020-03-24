using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaukriApplicatin.Models
{
    public class PreviousEmploymentDetail
    {
        public int PreviousEmploymentDetailId { get; set; }
        public int UserId { get; set; }
        public string Designation { get; set; }
        public string CompanyName { get; set; }
        public int StartYear { get; set; }
        public string StartMonth { get; set; }
        public int EndYear { get; set; }
        public string EndMonth { get; set; }
    }
}