using NaukriApplicatin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaukriApplicatin.Domains
{
    public class UserDomain:BaseDomain
    {
        public void UserAdd(User user)
        {
            this.ExecuteNonQuery($"insert into users(UserType,UserName,UserEmailId,UserPassword,MobileNumber,Address,Resume) values('{user.UserType}','{user.UserName}','{user.UserEmailId}','{user.UserPassword}','{user.MobileNumber}','{user.Address}','{user.Resume}')");
        }
        public int IsLogin(User user)
        {
            var reader = this.GetReader($"select * from users where UserEmailId='{user.UserEmailId}' and UserPassword='{user.UserPassword}'");
            var IsLoggedIn = 0;
            while (reader.Read())
            {
                IsLoggedIn = 1;
            }
            return IsLoggedIn;
        }
    }
}