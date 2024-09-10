using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.EFCRepo;
using Radhey.Repository.Interface.EFCRepo.UserLogin;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using Radhey.Model.ResponseModel;

using Radhey.DAL;
using Radhey.DAL.DatabaseContext;
using Radhey.DAL.IdentityTables;


using Radhey.ORM;
using Radhey.ORM.Linq;
using Radhey.ORM.Linq.Interface;


using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;





namespace Radhey.Repository.Implementation.EFCRepo.UserLogin
{
    public class UserLoginEFCRepo : IUserLoginEFCRepo
    {
        private readonly RadheyDbContext _dbContext;
        private readonly ICustom__Linq _custom__Linq;

        public UserLoginEFCRepo(
                                RadheyDbContext dbContext
                                ,ICustom__Linq custom__Linq
                                )
        {
            this._dbContext = dbContext;
            this._custom__Linq = custom__Linq;
        }

        public Task<ResponseComModel<object>> UserLogin__EFC(UserLogin__Req_Model userLogin__Req_Model)
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            //var IsEmailExist = _custom__Linq.CheckEmailExist(userLogin__Req_Model.Email);      
            var IsEmailExist = _custom__Linq.IsEmailExist(userLogin__Req_Model.Email);      
            

            
            if (IsEmailExist != null)
            {
                var CheckEmailPassword = _custom__Linq.CheckPassword(userLogin__Req_Model);
                
                if (CheckEmailPassword != null)
                {
                    response.StatusCode = 200;
                    response.Data = CheckEmailPassword;
                }
                else
                {
                    response.StatusCode = 400;
                }
            }
            else
            {
                response.StatusCode = 400;
            }
            return Task.FromResult(response);
        }




        

    }
}
