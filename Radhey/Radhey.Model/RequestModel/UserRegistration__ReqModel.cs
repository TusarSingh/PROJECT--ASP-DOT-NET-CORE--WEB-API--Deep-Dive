using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhey.Model.RequestModel
{
    public class UserRegistration__ReqModel
    {
#nullable disable
        public string FirstName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }    

        public string Phone { set; get; }
    }
}
