using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using Radhey.Repository.Interface.IdentityRepo;
using Radhey.Repository.Interface.IdentityRepo.UserRegistration;





namespace Radhey.Repository.Implementation.IdentityRepo
{
    public class AccountIdentityRepo : IAccountIdentityRepo
    {
        private readonly IUserRegistrationIdentityRepo _userRegistration;



        public AccountIdentityRepo(IUserRegistrationIdentityRepo userRegistration)
        {
            this._userRegistration = userRegistration;
        }

        public async Task<ResponseComModel> UserRegistration__Repo(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel response;

            response = await _userRegistration.UserRegistration__Identity(userRegistration__Req_Model);

            return response;
        }











    }
}
