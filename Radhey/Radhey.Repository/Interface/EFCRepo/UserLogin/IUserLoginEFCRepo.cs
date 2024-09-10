using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;




namespace Radhey.Repository.Interface.EFCRepo.UserLogin
{
    public interface IUserLoginEFCRepo
    {
        public Task<ResponseComModel<object>> UserLogin__EFC(UserLogin__Req_Model userLogin__Req_Model);
    }
}
