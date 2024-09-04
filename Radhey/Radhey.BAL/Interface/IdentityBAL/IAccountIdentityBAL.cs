using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;


namespace Radhey.BAL.Interface.IdentityBAL
{
    public interface IAccountIdentityBAL
    {
        public Task<ResponseComModel> UserRegistration__BAL(UserRegistration__Req_Model userRegistration__Req_Model);

        public Task<ResponseComModel<object>> UserLogin__BAL(UserLogin__Req_Model userLogin__Req_Model);

    }
}
