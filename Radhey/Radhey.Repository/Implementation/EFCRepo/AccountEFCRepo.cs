using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;


using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.EFCRepo;
using Radhey.Repository.Interface.EFCRepo.UserRegistration;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.DAL;
using Radhey.DAL.DatabaseContext;
using Radhey.DAL.IdentityTables;
using Radhey.Repository.Interface.EFCRepo.UserLogin;


namespace Radhey.Repository.Implementation.EFCRepo
{
    public class AccountEFCRepo : IAccountEFCRepo
    {
        private readonly IUserRegistrationEFCRepo _userRegistrationEFCRepo;
        private readonly IUserLoginEFCRepo _userLoginEFCRepo;

        public AccountEFCRepo(
                              IUserRegistrationEFCRepo userRegistrationEFCRepo
                              ,IUserLoginEFCRepo userLoginEFCRepo
                              )
        {
            this._userRegistrationEFCRepo = userRegistrationEFCRepo;
            this._userLoginEFCRepo = userLoginEFCRepo;
        }


        public async Task<ResponseComModel> UserRegistration__Repo(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel response;

            response = await _userRegistrationEFCRepo.UserRegistration__EFC(userRegistration__Req_Model).ConfigureAwait(false);

            return response;
        }

        public async Task<ResponseComModel<object>> UserLogin__Repo(UserLogin__Req_Model login__Req_Model)
        {
            ResponseComModel<object> response;

            response = await _userLoginEFCRepo.UserLogin__EFC(login__Req_Model ).ConfigureAwait(false);

            return response;
        }














    }
}
