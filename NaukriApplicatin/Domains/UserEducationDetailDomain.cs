using NaukriApplicatin.Models;
using NaukriApplicatin.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaukriApplicatin.Domains
{
    public class UserEducationDetailDomain:BaseDomain
    {
        public void Add(UserEducationDetail userEducationDetail)
        {
            this.ExecuteNonQuery($"insert into UserEducationDetails(UserId,Qualification,Course,Specialization,InstituteName,CourseType,PassingYear) values ({userEducationDetail.UserId},'{userEducationDetail.Qualification}','{userEducationDetail.Course}','{userEducationDetail.Specialization}','{userEducationDetail.InstituteName}','{userEducationDetail.Coursetype}',{userEducationDetail.PassingYear})");
        }
        public List<UserEducationDetail> Get(int userId)
        {
            var reader = this.GetReader($"select * from usereducationdetails where userId={userId}");
            var userEducationDetails = new List<UserEducationDetail>();
            while (reader.Read())
            {
                var userEducationDetail = new UserEducationDetail();
                userEducationDetail.Qualification = reader.GetString(2);
                userEducationDetail.Course = reader.GetString(3);
                userEducationDetail.Specialization = reader.GetString(4);
                userEducationDetail.InstituteName= reader.GetString(5);
                userEducationDetail.Coursetype= reader.GetString(6);
                userEducationDetail.PassingYear= reader.GetInt32(7);
                userEducationDetails.Add(userEducationDetail);
            }
            return userEducationDetails;
        }
    }
}