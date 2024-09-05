using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.BAL;
using Radhey.BAL.Interface;
using Radhey.BAL.Interface.EFCBAL;

using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.EFCRepo;
using Radhey.Repository.Interface.EFCRepo.UserRegistration;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;




namespace Radhey.BAL.Implementation.EFCBAL
{
    public class AccountEFCBAL : IAccountEFCBAL
    {

        private readonly IAccountEFCRepo _accountEFCRepo;
        public AccountEFCBAL(
                             IAccountEFCRepo accountEFCRepo
                            )
        {
            this._accountEFCRepo = accountEFCRepo;
        }

        public async Task<ResponseComModel> UserRegistration__BAL(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel response = new ResponseComModel();

            response = await _accountEFCRepo.UserRegistration__Repo(userRegistration__Req_Model).ConfigureAwait(false);

            return response;
        }

















    }
}
