using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.BAL;
using Radhey.BAL.Interface;
using Radhey.BAL.Interface.IIdentityByEFCBAL;









namespace Radhey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountByIdentityInEFCController : ControllerBase
    {

        private readonly IAccountByIdentityInEFCBAL _accountByIdentityInEFCBAL;

        public AccountByIdentityInEFCController(
                                                 IAccountByIdentityInEFCBAL accountByIdentityInEFCBAL

                                                )
        {
            this._accountByIdentityInEFCBAL = accountByIdentityInEFCBAL;
        }










        #region 

        #region User Registration Create Async

        [HttpPost]
        [Route("UserRegistrationCreateAsync")]
        public async Task<IActionResult> UserRegistrationCreateAsync(UserRegistration__ReqModel userRegistration__ReqModel)
        {
            ResponseComModel apiResponse = new ResponseComModel();

            if (userRegistration__ReqModel != null)
            {
                apiResponse = await _accountByIdentityInEFCBAL.UserRegistration(userRegistration__ReqModel);

                switch (apiResponse.StatusCode)
                {
                    case 200:
                        apiResponse = new ResponseComModel()
                        {
                            StatusCode = 200,
                            IsSuccess = true,
                            StatusMessage = "User Registration Successfully"
                        };
                        return Ok(apiResponse);

                    case 400:
                        apiResponse = new ResponseComModel()
                        {
                            StatusCode = 400,
                            IsSuccess = false,
                            StatusMessage = "User Registration Failed"
                        };
                        return BadRequest(apiResponse);

                    default:
                        apiResponse = new ResponseComModel()
                        {
                            StatusCode = 500,
                            IsSuccess = false,
                            StatusMessage = "Internal Server Error"
                        };
                        return Ok(apiResponse);
                }
            }
            else
            {
                apiResponse = new ResponseComModel()
                {
                    StatusCode = 500,
                    IsSuccess = false,
                    StatusMessage = "Internal Server Error"
                };
                return Ok(apiResponse);
            }
        }

        #endregion

       
        #endregion

    }
}
