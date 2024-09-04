using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;


namespace Radhey.Repository.Interface.IdentityRepo.UserRegistration
{
    public interface IUserRegistrationIdentityRepo
    {

        public Task<ResponseComModel> UserRegistration__Identity(UserRegistration__Req_Model userRegistration);
    }
}
