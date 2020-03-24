using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaukriApplicatin.Models
{
    public class User
    {
        public int UserId { get; set; }
        public bool UserType { get; set; }
        public string UserName { get; set; }
        public string UserEmailId { get; set; }
        public string UserPassword { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string Resume { get; set; }
    }
}