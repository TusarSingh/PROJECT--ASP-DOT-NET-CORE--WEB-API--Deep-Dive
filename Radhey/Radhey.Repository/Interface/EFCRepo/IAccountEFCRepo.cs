using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;



namespace Radhey.Repository.Interface.EFCRepo
{
    public interface IAccountEFCRepo
    {
        public Task<ResponseComModel> UserRegistration__Repo(UserRegistration__Req_Model userRegistration__Req_Model);

    }
}
