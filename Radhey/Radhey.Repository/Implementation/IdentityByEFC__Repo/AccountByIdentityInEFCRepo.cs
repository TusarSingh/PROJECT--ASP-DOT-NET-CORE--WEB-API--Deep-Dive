using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.DAL;
using Radhey.DAL.IdentityTables;
using Radhey.Repository.Interface.IIdentityByEFC__Repo;
using Radhey.Repository.Interface.IIdentityByEFC__Repo.IUserRegistration;





namespace Radhey.Repository.Implementation.IdentityByEFC__Repo
{
    public class AccountByIdentityInEFCRepo : IAccountByIdentityInEFCRepo
    {

        private readonly IUserRegistrationByIdentityInEFC _userRegistrationByIdentityInEFC;


        public AccountByIdentityInEFCRepo(
                                            IUserRegistrationByIdentityInEFC userRegistrationByIdentityInEFC

                                            )
        {
            this._userRegistrationByIdentityInEFC = userRegistrationByIdentityInEFC;
        }




        public async Task<ResponseComModel> UserRegistration(UserRegistration__ReqModel userRegistration)
        {

            ResponseComModel response  = new ResponseComModel();

            var user = await _userRegistrationByIdentityInEFC.UserRegistration(userRegistration);

            response.StatusCode = user.StatusCode;

            return response;

        }























    }
}
