using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.DAL;
using Radhey.DAL.DatabaseContext;
using Radhey.DAL.IdentityTables;


using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.IdentityRepo;
using Radhey.Repository.Interface.IdentityRepo.UserLogin;



using Radhey.ORM.Identity__By__EFC.Interface;



namespace Radhey.Repository.Implementation.IdentityRepo.UserLogin
{
    public class UserLoginIdentityRepo : IUserLoginIdentityRepo
    {
        private readonly ICustom__UserManager _userManager;


        public UserLoginIdentityRepo(
                                     ICustom__UserManager custom__UserManager
                                    )
        {
            this._userManager = custom__UserManager;
        }


        public async Task<ResponseComModel<object>> UserLogin__Identity(UserLogin__Req_Model userLogin__Req_Model)
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            var userExist = await _userManager.GetFindByEmailAsync(userLogin__Req_Model.Email);

            if (userExist != null)
            {
                var passCheck = await _userManager.GetCheckPasswordAsync(userExist, userLogin__Req_Model.Password);

                if (passCheck)
                {
                    response.StatusCode = 200;
                    response.Data = userExist;
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

            return response;
        }




















    }
}
