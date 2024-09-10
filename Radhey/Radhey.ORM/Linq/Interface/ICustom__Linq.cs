using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.Model.RequestModel;
using Radhey.Model.ResponseModel;

namespace Radhey.ORM.Linq.Interface
{
    public interface ICustom__Linq
    {

        public CheckEmailPassword__Res_Model? CheckEmailExist(string email);
        public CheckEmailPassword__Res_Model? IsEmailExist(string email);

        public CheckEmailPassword__Res_Model? CheckPassword(UserLogin__Req_Model userLogin__Req_Model);




    }
}
