using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaukriApplicatin.Models
{
    public class UserSkill
    {
        public int SkillId { get; set; }
        public int UserId { get; set; }
        public string SkillName { get; set; }
    }
}