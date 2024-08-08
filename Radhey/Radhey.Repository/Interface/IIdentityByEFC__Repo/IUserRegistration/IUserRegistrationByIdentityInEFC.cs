using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

namespace Radhey.Repository.Interface.IIdentityByEFC__Repo.IUserRegistration
{
    public interface IUserRegistrationByIdentityInEFC
    {

        public Task<ResponseComModel> UserRegistration(UserRegistration__ReqModel userRegistration__ReqModel);








    }
}
