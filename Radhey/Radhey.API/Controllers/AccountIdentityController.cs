﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Radhey.BAL.Interface.IdentityBAL;

using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.Utility.Common;


namespace Radhey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountIdentityController : ControllerBase
    {

        private readonly IAccountIdentityBAL _accountBal;
        public AccountIdentityController(IAccountIdentityBAL accountBal)
        {
            this._accountBal = accountBal;
        }

        [HttpPost]
        [Route("UserRegistration")]
        public async Task<IActionResult> UserRegistration(UserRegistration__Req_Model userRegistration__Req_Model)
        {
            ResponseComModel apiResponse;

            if (userRegistration__Req_Model != null)
            {

                apiResponse = await _accountBal.UserRegistration__BAL(userRegistration__Req_Model);

                
                switch  (apiResponse.StatusCode)
                {
                    case (int)ResponseEnum.okResponse:apiResponse = new ResponseComModel()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "User Registration Successfully Register."
                    };
                    return Ok(apiResponse);
                    case (int)ResponseEnum.BadRequest:apiResponse = new ResponseComModel()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = false,
                        StatusMessage = "User Registration Failed."
                    };
                    return Ok(apiResponse);
                    default :apiResponse = new ResponseComModel()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = false,
                        StatusMessage = "Internal Server Error"
                    };
                    return BadRequest(apiResponse);
                }
            }
            else
            {
                apiResponse = new ResponseComModel()
                {
                    StatusCode = (int)ResponseEnum.BadRequest,
                    StatusMessage = "",
                    IsSuccess = false
                };
            }
            return BadRequest(apiResponse);
        }

        [HttpPost]
        [Route("UserLogin")]
        public async Task<IActionResult> UserLogin(UserLogin__Req_Model userLogin)
        {
            ResponseComModel<object> apiResponse;

            if (ModelState.IsValid)
            {
                apiResponse = await _accountBal.UserLogin__BAL(userLogin);

                switch (apiResponse.StatusCode)
                {
                    case (int)ResponseEnum.okResponse: apiResponse = new ResponseComModel<object>
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "User Successfully Login",
                        Data = apiResponse.Data
                        
                    };
                    return Ok(apiResponse);
                    case (int)ResponseEnum.BadRequest: apiResponse = new ResponseComModel<object>
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = false,
                        StatusMessage = "User Login Failed",
                        Data = apiResponse.Data

                    };
                    return BadRequest(apiResponse);
                    default: apiResponse = new ResponseComModel<object>()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = false,
                        StatusMessage = "Internal Server Error",
                        Data = apiResponse.Data
                    };
                    return BadRequest(apiResponse);
                }
            }
            else
            {
                apiResponse = new ResponseComModel<object>()
                {
                    StatusCode = (int)ResponseEnum.BadRequest,
                    IsSuccess = false,
                    StatusMessage = "Internal Server Error",
                };
            }
            return BadRequest(apiResponse);
        }       
        
        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> AllUsers()
        {
            ResponseComModel<object> apiResponse;

            if (ModelState.IsValid)
            {
                apiResponse = await _accountBal.AllUsers__BAL().ConfigureAwait(false);


                switch (apiResponse.StatusCode)
                {
                    case (int)ResponseEnum.okResponse: apiResponse = new ResponseComModel<object>
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = true,
                        StatusMessage = "All Users Details",
                        Data = apiResponse.Data
                        
                    };
                    return Ok(apiResponse);
                    case (int)ResponseEnum.BadRequest: apiResponse = new ResponseComModel<object>
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = false,
                        StatusMessage = "Some Details Failed",
                        Data = apiResponse.Data

                    };
                    return BadRequest(apiResponse);
                    default: apiResponse = new ResponseComModel<object>()
                    {
                        StatusCode = apiResponse.StatusCode,
                        IsSuccess = false,
                        StatusMessage = "Internal Server Error",
                        Data = apiResponse.Data
                    };
                    return BadRequest(apiResponse);
                }
            }
            else
            {
                apiResponse = new ResponseComModel<object>()
                {
                    StatusCode = (int)ResponseEnum.BadRequest,
                    IsSuccess = false,
                    StatusMessage = "Internal Server Error",
                };
            }
            return BadRequest(apiResponse);
        }        
    }
}
