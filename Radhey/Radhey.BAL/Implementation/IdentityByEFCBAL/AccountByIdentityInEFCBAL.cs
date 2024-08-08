using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.BAL;
using Radhey.BAL.Interface;
using Radhey.BAL.Interface.IIdentityByEFCBAL;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.IIdentityByEFC__Repo;




namespace Radhey.BAL.Implementation.IdentityByEFCBAL
{
    public class AccountByIdentityInEFCBAL : IAccountByIdentityInEFCBAL
    {

        private readonly IAccountByIdentityInEFCRepo _accountByIdentityInEFCRepo;




        public AccountByIdentityInEFCBAL(
                                            IAccountByIdentityInEFCRepo accountByIdentityInEFCRepo
                                        )
        {
                this._accountByIdentityInEFCRepo = accountByIdentityInEFCRepo;
        }

        public async Task<ResponseComModel> UserRegistration(UserRegistration__ReqModel userRegistration__ReqModel)
        {

            ResponseComModel response = new ResponseComModel();

            var result = await _accountByIdentityInEFCRepo.UserRegistration(userRegistration__ReqModel);    

            response.StatusCode = result.StatusCode;

            return response;

        }























    }
}
