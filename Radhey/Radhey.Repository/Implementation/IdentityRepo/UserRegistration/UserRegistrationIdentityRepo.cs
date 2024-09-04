using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Repository.Interface.IdentityRepo.UserRegistration;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using Radhey.DAL.IdentityTables;


using Radhey.ORM.Identity__By__EFC;
using Radhey.ORM.Identity__By__EFC.Interface;
using Radhey.ORM.Identity__By__EFC.Implementation;





namespace Radhey.Repository.Implementation.IdentityRepo.UserRegistration

{
    public class UserRegistrationIdentityRepo : IUserRegistrationIdentityRepo
    {

        private readonly ICustom__UserManager _customUserManager;



        public UserRegistrationIdentityRepo(ICustom__UserManager customUserManager)
        {
            this._customUserManager = customUserManager;
        }


        public async Task<ResponseComModel> UserRegistration__Identity(UserRegistration__Req_Model userRegistration__Req_Model)
        {

            ResponseComModel response = new ResponseComModel();

            TblApplicationUser tblApplicationUser = new TblApplicationUser()
            {
                FirstName = userRegistration__Req_Model.FirstName,
                LastName = userRegistration__Req_Model.LastName,
                UserName = userRegistration__Req_Model.FirstName + userRegistration__Req_Model.LastName,
                Email = userRegistration__Req_Model.Email,
                PasswordHash = userRegistration__Req_Model.password
            };


            // User Registration With out Password Encryption

            //var User = await _customUserManager.PostCreateAsync(tblApplicationUser);
            
            // User Registration With Password Encryption

            var User = await _customUserManager.PostCreateAsync(tblApplicationUser, userRegistration__Req_Model.password);

            if(User.Succeeded)
            {
                response.StatusCode = 200;
            }
            else
            {
                response.StatusCode = 400;
            }
            return response;

        }














    }
}
