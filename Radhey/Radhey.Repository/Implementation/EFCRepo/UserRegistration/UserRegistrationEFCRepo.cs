using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Interface.EFCRepo;
using Radhey.Repository.Interface.EFCRepo.UserRegistration;


using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.DAL;
using Radhey.DAL.DatabaseContext;
using Radhey.DAL.IdentityTables;


namespace Radhey.Repository.Implementation.EFCRepo.UserRegistration
{
    public class UserRegistrationEFCRepo : IUserRegistrationEFCRepo
    {

        private readonly RadheyDbContext _dbContext;
        public UserRegistrationEFCRepo(RadheyDbContext dbContext)
        {
           this._dbContext = dbContext;
        }

        public async Task<ResponseComModel> UserRegistration__EFC(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel response = new ResponseComModel();

            TblApplicationUser tblApplicationUser = new TblApplicationUser()
            {
                FirstName = userRegistration__Req_Model.FirstName,
                LastName = userRegistration__Req_Model.LastName,
                UserName = userRegistration__Req_Model.FirstName + " " + userRegistration__Req_Model.LastName,
                Email = userRegistration__Req_Model.Email,
                PasswordHash = userRegistration__Req_Model.password,
                PhoneNumber = userRegistration__Req_Model.PhoneNumber
            };

            var user = _dbContext.AspNetUsers.Add(tblApplicationUser);

            var userSuccess = await _dbContext.SaveChangesAsync();

            if(userSuccess == 1)
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
