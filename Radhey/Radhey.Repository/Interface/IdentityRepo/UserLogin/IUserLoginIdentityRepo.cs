using Radhey.Model.CommonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model.RequestModel;


namespace Radhey.Repository.Interface.IdentityRepo.UserLogin
{
    public interface IUserLoginIdentityRepo
    {

        public Task<ResponseComModel<Object>> UserLogin__Identity(UserLogin__Req_Model userLogin__Req_Model);


    }
}
