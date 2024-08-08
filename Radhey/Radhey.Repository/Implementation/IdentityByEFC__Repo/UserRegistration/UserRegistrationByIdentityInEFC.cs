using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Repository.Interface.IIdentityByEFC__Repo;
using Radhey.Repository.Interface.IIdentityByEFC__Repo.IUserRegistration;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;
using Radhey.DAL.IdentityTables;

using Radhey.ORM.IdentityByEFC;
using Radhey.ORM.IdentityByEFC.Interface;
using Radhey.ORM.IdentityByEFC.Implementation;


namespace Radhey.Repository.Implementation.IdentityByEFC__Repo.UserRegistration
{
    public class UserRegistrationByIdentityInEFC : IUserRegistrationByIdentityInEFC
    {

        private readonly ICustomUserManager _customUserManager;
        


        public UserRegistrationByIdentityInEFC(
                                                ICustomUserManager customUserManager
                
                                                )
        {
            this._customUserManager = customUserManager;
            
        }


        #region User Registration with out Password Encryption

        //public async Task<ResponseComModel> UserRegistration(UserRegistration__ReqModel userRegistration__ReqModel)
        //{

        //    ResponseComModel response = new ResponseComModel();

        //    TblApplicationUser tblApplicationUser = new TblApplicationUser()
        //    {
        //        FirstName = userRegistration__ReqModel.FirstName,
        //        Email = userRegistration__ReqModel.Email,
        //        PasswordHash = userRegistration__ReqModel.Password,
        //        PhoneNumber = userRegistration__ReqModel.Phone
        //    };

        //    var user = await this._customUserManager.PostCreateAsync(tblApplicationUser);

        //    if (user.Succeeded)
        //    {
        //        response.StatusCode = 200;
        //    }
        //    else
        //    {
        //        response.StatusCode = 400;
        //    }




        //    return response;
        //}

        #endregion

        #region User Registration with Password Encryption

        public async Task<ResponseComModel> UserRegistration(UserRegistration__ReqModel userRegistration__ReqModel)
        {

            ResponseComModel response = new ResponseComModel();

            TblApplicationUser tblApplicationUser = new TblApplicationUser()
            {
                FirstName = userRegistration__ReqModel.FirstName,
                Email = userRegistration__ReqModel.Email,
                PasswordHash = userRegistration__ReqModel.Password,
                PhoneNumber = userRegistration__ReqModel.Phone
            };

            var user = await this._customUserManager.PostCreateAsync(tblApplicationUser, tblApplicationUser.PasswordHash);

            if (user.Succeeded)
            {
                response.StatusCode = 200;
            }
            else
            {
                response.StatusCode = 400;
            }




            return response;
        }

        #endregion



    }
}
