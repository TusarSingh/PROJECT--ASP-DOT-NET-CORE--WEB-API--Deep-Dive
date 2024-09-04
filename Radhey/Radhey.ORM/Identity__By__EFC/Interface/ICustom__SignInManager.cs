using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Radhey.DAL.IdentityTables;


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace Radhey.ORM.Identity__By__EFC.Interface
{
    public interface ICustom__SignInManager
    {
        public Task<bool> GetCanSignInAsync(TblApplicationUser user);

        public Task<SignInResult> GetCheckPasswordSignInAsync(TblApplicationUser user, string password, bool lockoutOnFailure);

        //public Task<TblApplicationUser> GetConfigureExternalAuthenticationProperties(string provider,string redirectUrl,string userId);

        public Task<ClaimsPrincipal> GetCreateUserPrincipalAsync(TblApplicationUser user);

        public Task<SignInResult> GetExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent);

        public Task<SignInResult> GetExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent, bool bypassTwoFactor);

        //public Task<TblApplicationUser> GetForgetTwoFactorClientAsync(TblApplicationUser user);

        public Task<IEnumerable<AuthenticationScheme>> GetGetExternalAuthenticationSchemesAsync(TblApplicationUser user);

        public Task<ExternalLoginInfo> GetGetExternalLoginInfoAsync(string expectedXsrf = null);

        public Task<TblApplicationUser> GetGetTwoFactorAuthenticationUserAsync(TblApplicationUser user);

        //public Task<bool> GetIsLockedOut(TblApplicationUser user);

        //public Task<bool> GetIsSignedIn(ClaimsPrincipal claimsPrincipal);

        public Task<bool> GetIsTwoFactorClientRememberedAsync(TblApplicationUser user);

        //public Task<SignInResult> GetLockedOut(TblApplicationUser user);

        public Task<SignInResult> GetPasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure);

        public Task<SignInResult> GetPasswordSignInAsync(TblApplicationUser user, string password, bool isPersistent, bool lockoutOnFailure);

        //public Task<SignInResult> GetPreSignInCheck(TblApplicationUser user);

        //public Task<TblApplicationUser> GetRefreshSignInAsync(TblApplicationUser user);

        //public Task<TblApplicationUser> GetRememberTwoFactorClientAsync(TblApplicationUser user);

        //public Task<TblApplicationUser> GetResetLockout(TblApplicationUser user);

        //public Task<TblApplicationUser> GetSignInAsync(TblApplicationUser user,bool isPersistent,string authenticationMethod);

        //public Task<TblApplicationUser> GetSignInAsync(TblApplicationUser user,AuthenticationProperties authenticationProperties,string authenticationMethod);

        //public Task<SignInResult> GetSignInOrTwoFactorAsync(TblApplicationUser user,bool isPersistent,string loginProvider= null,bool bypassTwoFactor = false);

        //public Task<TblApplicationUser> GetSignInWithClaimsAsync(TblApplicationUser user,AuthenticationProperties authenticationProperties,IEnumerable<Claim> claim);

        //public Task<TblApplicationUser> GetSignInWithClaimsAsync(TblApplicationUser user,bool isPersistent,IEnumerable<Claim> claim);

        //public Task<TblApplicationUser> GetSignOutAsync(TblApplicationUser user);

        public Task<SignInResult> GetTwoFactorAuthenticatorSignInAsync(string code, bool isPersistent, bool rememberClient);

        public Task<SignInResult> GetTwoFactorRecoveryCodeSignInAsync(string recoveryCode);

        public Task<SignInResult> GetTwoFactorSignInAsync(string provider, string code, bool isPersistent, bool rememberClient);
        public Task<IdentityResult> GetUpdateExternalAuthenticationTokensAsync(ExternalLoginInfo externalLogin);

        public Task<TblApplicationUser> GetValidateSecurityStampAsync(ClaimsPrincipal principal);

        public Task<bool> GetValidateSecurityStampAsync(TblApplicationUser user, string securityStamp);

        public Task<TblApplicationUser> Getxyz(ClaimsPrincipal principal);

    }
}
