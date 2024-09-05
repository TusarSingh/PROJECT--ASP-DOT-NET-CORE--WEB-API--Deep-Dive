using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

namespace Radhey.Repository.Interface.IdentityRepo
{
    public interface IAccountIdentityRepo
    {
        public Task<ResponseComModel> UserRegistration__Repo(UserRegistration__Req_Model userRegistration__Req_Model);

        public Task<ResponseComModel<object>> UserLogin__Repo(UserLogin__Req_Model login__Req_Model);
        public Task<ResponseComModel<object>> AllUsers__Repo();


    }
}
