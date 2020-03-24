using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaukriApplicatin.Models
{
    public class UserEducationDetail
    {
        public int UserEducationDetailId { get; set; }
        public int UserId { get; set; }
        public string Qualification { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public string InstituteName { get; set; }
        public string Coursetype { get; set; }
        public int PassingYear { get; set; }
    }
}