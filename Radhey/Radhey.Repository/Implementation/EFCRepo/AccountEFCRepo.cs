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


namespace Radhey.Repository.Implementation.EFCRepo
{
    public class AccountEFCRepo : IAccountEFCRepo
    {
        private readonly IUserRegistrationEFCRepo _userRegistrationEFCRepo;

        public AccountEFCRepo(
                              IUserRegistrationEFCRepo userRegistrationEFCRepo
                              )
        {
            this._userRegistrationEFCRepo = userRegistrationEFCRepo;             
        }


        public async Task<ResponseComModel> UserRegistration__Repo(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel response;

            response = await _userRegistrationEFCRepo.UserRegistration__EFC(userRegistration__Req_Model).ConfigureAwait(false);

            return response;
        }















    }
}
