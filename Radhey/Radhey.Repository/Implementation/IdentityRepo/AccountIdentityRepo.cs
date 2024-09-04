using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;


using Radhey.Repository.Interface.IdentityRepo;
using Radhey.Repository.Interface.IdentityRepo.UserRegistration;
using Radhey.Repository.Interface.IdentityRepo.UserLogin;




namespace Radhey.Repository.Implementation.IdentityRepo
{
    public class AccountIdentityRepo : IAccountIdentityRepo
    {
        private readonly IUserRegistrationIdentityRepo _userRegistration;
        private readonly IUserLoginIdentityRepo _userLogin;


        public AccountIdentityRepo(
                                    IUserRegistrationIdentityRepo userRegistration
                                   ,IUserLoginIdentityRepo userLogin
                                    )
        {
            this._userRegistration = userRegistration;
            this._userLogin = userLogin;    
        }

        public async Task<ResponseComModel> UserRegistration__Repo(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel response;

            response = await _userRegistration.UserRegistration__Identity(userRegistration__Req_Model);

            return response;
        }


        public async Task<ResponseComModel<object>> UserLogin__Repo(UserLogin__Req_Model userLogin__Req_Model)
        {
            ResponseComModel<object> response;

            response = await _userLogin.UserLogin__Identity(userLogin__Req_Model);

            return response;
        }










    }
}
