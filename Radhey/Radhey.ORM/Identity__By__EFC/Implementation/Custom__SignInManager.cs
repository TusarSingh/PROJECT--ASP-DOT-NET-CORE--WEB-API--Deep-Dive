using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Radhey.ORM.Identity__By__EFC.Interface;
using Radhey.DAL.IdentityTables;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace Radhey.ORM.Identity__By__EFC.Implementation
{
    public class Custom__SignInManager : ICustom__SignInManager
    {
        private readonly UserManager<TblApplicationUser> _userManager;
        private readonly SignInManager<TblApplicationUser> _signInManager;


        public Custom__SignInManager(
                                    UserManager<TblApplicationUser> userManager,
                                    SignInManager<TblApplicationUser> signInManager
                                  )
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        #region User Login 

        public async Task<SignInResult> GetPasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var a = await _signInManager.PasswordSignInAsync(userName, password, isPersistent, lockoutOnFailure);
            return a;
        }
        public async Task<SignInResult> GetPasswordSignInAsync(TblApplicationUser user, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var a = await _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
            return a;
        }

        #endregion

        public async Task<bool> GetCanSignInAsync(TblApplicationUser user)
        {
            var a = await _signInManager.CanSignInAsync(user);
            return a;
        }
        public async Task<SignInResult> GetCheckPasswordSignInAsync(TblApplicationUser user, string password, bool lockoutOnFailure)
        {
            var a = await _signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure);
            return a;
        }
        //public async Task<TblApplicationUser> GetConfigureExternalAuthenticationProperties(string provider,string redirectUrl,string userId)
        //{
        //    var a = await _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl, userId);
        //    return a;
        //}
        public async Task<ClaimsPrincipal> GetCreateUserPrincipalAsync(TblApplicationUser user)
        {
            var a = await _signInManager.CreateUserPrincipalAsync(user);
            return a;
        }
        public async Task<SignInResult> GetExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent)
        {
            var a = await _signInManager.ExternalLoginSignInAsync(loginProvider, providerKey, isPersistent);
            return a;
        }
        public async Task<SignInResult> GetExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent, bool bypassTwoFactor)
        {
            var a = await _signInManager.ExternalLoginSignInAsync(loginProvider, providerKey, isPersistent, bypassTwoFactor);
            return a;
        }
        //public async Task<TblApplicationUser> GetForgetTwoFactorClientAsync(TblApplicationUser user)
        //{
        //    var a = await _signInManager.ForgetTwoFactorClientAsync();
        //    return a;
        //} 
        public async Task<IEnumerable<AuthenticationScheme>> GetGetExternalAuthenticationSchemesAsync(TblApplicationUser user)
        {
            var a = await _signInManager.GetExternalAuthenticationSchemesAsync();
            return a;
        }
        public async Task<ExternalLoginInfo> GetGetExternalLoginInfoAsync(string expectedXsrf = null)
        {
            var a = await _signInManager.GetExternalLoginInfoAsync(expectedXsrf);
            return a;
        }
        public async Task<TblApplicationUser> GetGetTwoFactorAuthenticationUserAsync(TblApplicationUser user)
        {
            var a = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            return a;
        }
        //public async Task<bool> GetIsLockedOut(TblApplicationUser user)
        //{
        //    var a = await _signInManager.IsLockedOut(user);
        //    return a;
        //} 
        //public async Task<bool> GetIsSignedIn(ClaimsPrincipal claimsPrincipal)
        //{
        //    var a = await _signInManager.IsSignedIn(claimsPrincipal);
        //    return a;
        //} 
        public async Task<bool> GetIsTwoFactorClientRememberedAsync(TblApplicationUser user)
        {
            var a = await _signInManager.IsTwoFactorClientRememberedAsync(user);
            return a;
        }
        //public async Task<SignInResult> GetLockedOut(TblApplicationUser user)
        //{
        //    var a = await _signInManager.LockedOut(user);
        //    return a;
        //} 


        //public async Task<SignInResult> GetPreSignInCheck(TblApplicationUser user)
        //{
        //    var a = await _signInManager.PreSignInCheck(user);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetRefreshSignInAsync(TblApplicationUser user)
        //{
        //    var a = await _signInManager.RefreshSignInAsync(user);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetRememberTwoFactorClientAsync(TblApplicationUser user)
        //{
        //    var a = await _signInManager.RememberTwoFactorClientAsync(user);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetResetLockout(TblApplicationUser user)
        //{
        //    var a = await _signInManager.ResetLockout(user);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetSignInAsync(TblApplicationUser user,bool isPersistent,string authenticationMethod)
        //{
        //    var a = await _signInManager.SignInAsync(user,isPersistent,authenticationMethod = null);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetSignInAsync(TblApplicationUser user,AuthenticationProperties authenticationProperties,string authenticationMethod)
        //{
        //    var a = await _signInManager.SignInAsync(user, authenticationProperties, authenticationMethod);
        //    return a;
        //} 
        //public async Task<SignInResult> GetSignInOrTwoFactorAsync(TblApplicationUser user,bool isPersistent,string loginProvider= null,bool bypassTwoFactor = false)
        //{
        //    var a = await _signInManager.SignInOrTwoFactorAsync(user,isPersistent,loginProvider,bypassTwoFactor);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetSignInWithClaimsAsync(TblApplicationUser user,AuthenticationProperties authenticationProperties,IEnumerable<Claim> claim)
        //{
        //    var a = await _signInManager.SignInWithClaimsAsync(user, authenticationProperties, claim);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetSignInWithClaimsAsync(TblApplicationUser user,bool isPersistent,IEnumerable<Claim> claim)
        //{
        //    var a = await _signInManager.SignInWithClaimsAsync(user,isPersistent, claim);
        //    return a;
        //} 
        //public async Task<TblApplicationUser> GetSignOutAsync(TblApplicationUser user)
        //{
        //    var a = await _signInManager.SignOutAsync();
        //    return a;
        //} 
        public async Task<SignInResult> GetTwoFactorAuthenticatorSignInAsync(string code, bool isPersistent, bool rememberClient)
        {
            var a = await _signInManager.TwoFactorAuthenticatorSignInAsync(code, isPersistent, rememberClient);
            return a;
        }
        public async Task<SignInResult> GetTwoFactorRecoveryCodeSignInAsync(string recoveryCode)
        {
            var a = await _signInManager.TwoFactorRecoveryCodeSignInAsync(recoveryCode);
            return a;
        }
        public async Task<SignInResult> GetTwoFactorSignInAsync(string provider, string code, bool isPersistent, bool rememberClient)
        {
            var a = await _signInManager.TwoFactorSignInAsync(provider, code, isPersistent, rememberClient);
            return a;
        }
        public async Task<IdentityResult> GetUpdateExternalAuthenticationTokensAsync(ExternalLoginInfo externalLogin)
        {
            var a = await _signInManager.UpdateExternalAuthenticationTokensAsync(externalLogin);
            return a;
        }
        public async Task<TblApplicationUser> GetValidateSecurityStampAsync(ClaimsPrincipal principal)
        {
            var a = await _signInManager.ValidateSecurityStampAsync(principal);
            return a;
        }

        public async Task<bool> GetValidateSecurityStampAsync(TblApplicationUser user, string securityStamp)
        {
            var a = await _signInManager.ValidateSecurityStampAsync(user, securityStamp);
            return a;
        }

        public async Task<TblApplicationUser> Getxyz(ClaimsPrincipal principal)
        {
            var a = await _signInManager.ValidateTwoFactorSecurityStampAsync(principal);
            return a;
        }

    }
}
