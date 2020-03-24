using NaukriApplicatin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApplicatin.Domains
{
    public class UserSkillDomain:BaseDomain
    {
        public void Add(UserSkill userSkill)
        {
            this.ExecuteNonQuery($"insert into userskills(SkillName,UserId) values('{userSkill.SkillName}',{userSkill.UserId})");
        }

        public List<UserSkill> Get(int userId)
        {
            var reader = this.GetReader($"select * from userSkills where UserId={userId}");
            var userSkills = new List<UserSkill>();
            while (reader.Read())
            {
                var userSkill = new UserSkill();
                userSkill.SkillName = reader.GetString(1);
                userSkill.UserId = reader.GetInt32(2);
                userSkills.Add(userSkill);
            }
            return userSkills;
        }
    }
}
