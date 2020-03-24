using NaukriApplicatin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApplicatin.Domains
{
    public class PreviousEmploymentDetailDomain:BaseDomain
    {
        public void Add(PreviousEmploymentDetail previousEmploymentDetail)
        {
            this.ExecuteNonQuery($"insert into PreviousEmploymentDetails(UserId,Designation,CompanyName,StartYear,StartMonth,EndYear,EndMonth) values({previousEmploymentDetail.UserId},'{previousEmploymentDetail.Designation}','{previousEmploymentDetail.CompanyName}','{previousEmploymentDetail.StartYear}','{previousEmploymentDetail.StartMonth}','{previousEmploymentDetail.EndYear}','{previousEmploymentDetail.EndMonth}')");
        }

        public List<PreviousEmploymentDetail> Get(int userId)
        {
            var previousEmploymentDetails = new List<PreviousEmploymentDetail>();
            var reader = this.GetReader($"select * from PreviousEmploymentDetails where UserId={userId}");
            while (reader.Read())
            {
                var previousEmpoymentDetail = new PreviousEmploymentDetail();
                previousEmpoymentDetail.UserId = reader.GetInt32(1);
                previousEmpoymentDetail.Designation = reader.GetString(2);
                previousEmpoymentDetail.CompanyName = reader.GetString(3);
                previousEmpoymentDetail.StartYear = reader.GetInt32(4);
                previousEmpoymentDetail.StartMonth = reader.GetString(5);
                previousEmpoymentDetail.EndYear = reader.GetInt32(6);
                previousEmpoymentDetail.EndMonth = reader.GetString(7);
                previousEmploymentDetails.Add(previousEmpoymentDetail);
            }
            return previousEmploymentDetails;
        }
    }
}
