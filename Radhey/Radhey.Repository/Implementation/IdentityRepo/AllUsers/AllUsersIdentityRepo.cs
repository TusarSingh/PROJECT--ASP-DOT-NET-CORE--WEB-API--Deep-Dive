using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.IdentityRepo;
using Radhey.Repository.Interface.IdentityRepo.AllUser;

using Radhey.ORM;
using Radhey.ORM.Identity__By__EFC;
using Radhey.ORM.Identity__By__EFC.Interface;

using Radhey.Model;
using Radhey.Model.CommonModel;



namespace Radhey.Repository.Implementation.IdentityRepo.AllUsers
{
    public class AllUsersIdentityRepo : IAllUsersIdentityRepo
    {
        private readonly ICustom__UserManager _userManager;

        public AllUsersIdentityRepo(
                                    ICustom__UserManager userManager
                                    )
        {
            this._userManager = userManager;
        }


        public async Task<ResponseComModel<object>> AllUsersIdentity()
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            response = await _userManager.GetUser().ConfigureAwait(false); ;

            if( response != null )
            {
                response.StatusCode = 200;
                response.Data = response.Data;
            }
            else
            {
                response.StatusCode = 400;
            }

            return response;
        }







    }
}
