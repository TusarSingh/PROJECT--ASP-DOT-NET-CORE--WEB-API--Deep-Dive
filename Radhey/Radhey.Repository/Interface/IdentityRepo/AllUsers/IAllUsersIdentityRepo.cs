using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;



namespace Radhey.Repository.Interface.IdentityRepo.AllUser
{
    public interface IAllUsersIdentityRepo
    {

        public Task<ResponseComModel<object>> AllUsersIdentity();


    }
}
