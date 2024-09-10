using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Radhey.BAL;
using Radhey.BAL.Interface;
using Radhey.BAL.Interface.EFCBAL;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;



namespace Radhey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountEFCController : ControllerBase
    {
        private readonly IAccountEFCBAL _accountEFCBAL;

        public AccountEFCController(
                                    IAccountEFCBAL accountEFCBAL
                                    )
        {
            this._accountEFCBAL = accountEFCBAL;
        }

        [HttpPost]
        [Route("UserRegistration")]
        public async Task<IActionResult> UserRegistration(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel apiResponse;

            if(ModelState.IsValid)
            {
                apiResponse = await _accountEFCBAL.UserRegistration__BAL(userRegistration__Req_Model).ConfigureAwait(false);

                switch (apiResponse.StatusCode)
                {
                    case 200:apiResponse = new ResponseComModel()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "User Registration Successfully"
                    };
                    return Ok(apiResponse);
                    case 400:apiResponse = new ResponseComModel()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "User Registration Failed"
                    };
                    return BadRequest(apiResponse);
                    default:apiResponse = new ResponseComModel()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "Internal Server Error"
                    };
                    return Ok(apiResponse);
                } 
            }
            else
            {
                apiResponse = new ResponseComModel()
                {
                    StatusCode = 400,
                    IsSuccess = true,
                    StatusMessage = "Internal Server Error"
                };
            }
            return BadRequest(apiResponse);
        }
        
        [HttpPost]
        [Route("UserLogin")]
        public async Task<IActionResult> UserLogin(UserLogin__Req_Model userLogin__Req_Model)
        {
            ResponseComModel<object> apiResponse;

            if(ModelState.IsValid)
            {
                apiResponse = await _accountEFCBAL.UserLogin__BAL(userLogin__Req_Model).ConfigureAwait(false);

                switch (apiResponse.StatusCode)
                {
                    case 200:apiResponse = new ResponseComModel<object>()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "User Login Successfully",
                        Data = apiResponse.Data
                        
                    };
                    return Ok(apiResponse);
                    case 400:apiResponse = new ResponseComModel<object>()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "User Login Failed"
                    };
                    return BadRequest(apiResponse);
                    default:apiResponse = new ResponseComModel<object>()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "Internal Server Error"
                    };
                    return Ok(apiResponse);
                } 
            }
            else
            {
                apiResponse = new ResponseComModel<object>()
                {
                    StatusCode = 400,
                    IsSuccess = true,
                    StatusMessage = "Internal Server Error"
                };
            }
            return BadRequest(apiResponse);
        }
    }
}
