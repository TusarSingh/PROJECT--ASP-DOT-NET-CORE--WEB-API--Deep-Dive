using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.BAL.Interface.IdentityBAL;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.IdentityRepo;



namespace Radhey.BAL.Implementation.IdentityBAL
{
    public class AccountIdentityBAL : IAccountIdentityBAL 
    {
        private readonly IAccountIdentityRepo _accountRepo;

        public AccountIdentityBAL(IAccountIdentityRepo accountRepo)
        {
            this._accountRepo = accountRepo;
        }

        public async Task<ResponseComModel> UserRegistration__BAL(UserRegistration__Req_Model userRegistration__Req_Model)
        {

            var responseComModel = new ResponseComModel();

            responseComModel = await _accountRepo.UserRegistration__Repo(userRegistration__Req_Model);

            return responseComModel;

        }

        public async Task<ResponseComModel<object>> UserLogin__BAL(UserLogin__Req_Model userLogin__Req_Model)
        {
            var response = new ResponseComModel<object>();

            response = await _accountRepo.UserLogin__Repo(userLogin__Req_Model);

            return response;
        }




    }
}
