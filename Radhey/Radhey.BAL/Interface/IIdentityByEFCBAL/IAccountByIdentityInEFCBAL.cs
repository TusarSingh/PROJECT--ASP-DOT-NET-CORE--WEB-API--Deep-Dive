using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;


namespace Radhey.BAL.Interface.IIdentityByEFCBAL
{
    public interface IAccountByIdentityInEFCBAL
    {

        public Task<ResponseComModel> UserRegistration(UserRegistration__ReqModel userRegistration__ReqModel);
    }
}
