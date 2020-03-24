using NaukriApplicatin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApplicatin.Domains
{
    public class UserEmploymentDetailDomain:BaseDomain
    {
        public void Add(UserEmploymentDetail userEmploymentDetail)
        {
            this.ExecuteNonQuery($"insert into useremploymentdetails(UserId,Designation,CompanyName,SalaryLakhs,SalaryThousands,StartYear,StartMonth,EndYear,EndMonth,City,NoticePeriod,Industry,FunctionalArea,Role) values({userEmploymentDetail.UserId},'{userEmploymentDetail.Designation}','{userEmploymentDetail.CompanyName}','{userEmploymentDetail.SalaryLakhs}','{userEmploymentDetail.SalaryThousands}',{userEmploymentDetail.StartYear},'{userEmploymentDetail.StartMonth}',{userEmploymentDetail.EndYear},'{userEmploymentDetail.EndMonth}','{userEmploymentDetail.City}','{userEmploymentDetail.NoticPeriod}','{userEmploymentDetail.Industry}','{userEmploymentDetail.FunctionalArea}','{userEmploymentDetail.Role}')");
        }
        public List<UserEmploymentDetail> Get(int userId)
        {
            var reader = this.GetReader($"select * from useremploymentDetails where userId={userId}");
            var userEmpolymentDetails = new List<UserEmploymentDetail>();
            while (reader.Read())
            {
                var userEmploymentDetail = new UserEmploymentDetail();
                userEmploymentDetail.Designation = reader.GetString(2);
                userEmploymentDetail.CompanyName = reader.GetString(3);
                userEmploymentDetail.SalaryLakhs = reader.GetString(4);
                userEmploymentDetail.SalaryThousands = reader.GetString(5);
                userEmploymentDetail.StartYear = reader.GetInt32(6);
                userEmploymentDetail.StartMonth = reader.GetString(7);
                userEmploymentDetail.EndYear = reader.GetInt32(8);
                userEmploymentDetail.EndMonth = reader.GetString(9);
                userEmploymentDetail.City = reader.GetString(10);
                userEmploymentDetail.NoticPeriod = reader.GetString(11);
                userEmploymentDetail.Industry = reader.GetString(12);
                userEmploymentDetail.FunctionalArea = reader.GetString(13);
                userEmploymentDetail.Role = reader.GetString(14);
                userEmpolymentDetails.Add(userEmploymentDetail);
            }
            return userEmpolymentDetails;
        }
    }
}
