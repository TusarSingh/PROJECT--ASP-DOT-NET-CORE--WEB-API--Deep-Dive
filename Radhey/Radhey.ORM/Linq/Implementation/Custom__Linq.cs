//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.ORM.Linq.Interface;

using Radhey.Model.RequestModel;
using Radhey.Model.ResponseModel;

using Radhey.DAL.DatabaseContext;


namespace Radhey.ORM.Linq.Implementation
{
    public class Custom__Linq : ICustom__Linq
    {
        private readonly RadheyDbContext _dbContext;  

        public Custom__Linq(RadheyDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public CheckEmailPassword__Res_Model? IsEmailExist(string email)
        {
            CheckEmailPassword__Res_Model userResponse = new CheckEmailPassword__Res_Model();

            var EmailExist = from user in _dbContext.AspNetUsers
                            where user.Email == email
                            select user;

            if(EmailExist != null)
            {
                foreach (var item in EmailExist)
                {
                    userResponse.Email = item.Email;
                    userResponse.Password = item.PasswordHash;
                    userResponse.FirstName = item.FirstName;
                    userResponse.LastName = item.LastName;
                }
                return userResponse;
            }
            else
            {
                return null;
            }


            


            //if (EmailExist != null)
            //{
            //    userResponse.FirstName = EmailExist;
            //    userResponse.LastName = userEmail.LastName;
            //    userResponse.Email = userEmail.Email;
            //    userResponse.Password = userEmail.PasswordHash;
            //    return userResponse;
            //}
            //else
            //{
            //    return null;
            //}
        }

        public CheckEmailPassword__Res_Model? CheckEmailExist(string email)
        {
            CheckEmailPassword__Res_Model userResponse = new CheckEmailPassword__Res_Model();

            var userEmail = from user in _dbContext.AspNetUsers
                            where user.Email == email
                            select user;



            var IsEmailExist = _dbContext.AspNetUsers.SingleOrDefault(x => x.Email == email);

            if (IsEmailExist != null)
            {
                userResponse.FirstName = IsEmailExist.FirstName;
                userResponse.LastName = IsEmailExist.LastName;
                userResponse.Email = IsEmailExist.Email;
                userResponse.Password = IsEmailExist.PasswordHash;
                return userResponse;
            }
            else
            {
                return null;
            }
        }

        public CheckEmailPassword__Res_Model? CheckPassword(UserLogin__Req_Model userLogin__Req_Model)
        {
            CheckEmailPassword__Res_Model userResponse = new CheckEmailPassword__Res_Model();

            var pass = _dbContext.AspNetUsers.Where(x => x.Email == userLogin__Req_Model.Email).SingleOrDefault(x => x.PasswordHash == userLogin__Req_Model.Password);

            if (pass != null)
            {
                userResponse.FirstName = pass.FirstName;
                userResponse.LastName = pass.LastName;
                userResponse.Email = pass.Email;
                userResponse.Password = pass.PasswordHash;
                return userResponse;
            }
            else
            {
                return null;
            }
        }


    }
}
