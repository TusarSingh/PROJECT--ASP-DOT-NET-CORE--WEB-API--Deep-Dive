using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;


namespace Radhey.Repository.Interface.EFCRepo.UserRegistration
{
    public interface IUserRegistrationEFCRepo
    {
        public Task<ResponseComModel> UserRegistration__EFC(UserRegistration__Req_Model userRegistration__Req_Model);

    }
}
