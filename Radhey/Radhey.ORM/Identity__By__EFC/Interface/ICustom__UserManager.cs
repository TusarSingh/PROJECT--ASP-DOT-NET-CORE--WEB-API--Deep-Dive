using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Radhey.DAL.IdentityTables;

using Radhey.Model.CommonModel;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace Radhey.ORM.Identity__By__EFC.Interface
{
    public interface ICustom__UserManager
    {
        // use Properties

        #region Use Properties for GetAllUsers
        public Task<ResponseComModel<object>> GetUser();

        #endregion

        public Task<IdentityResult> GetAccessFailedAsync(TblApplicationUser user);


        public Task<IdentityResult> GetAddClaimAsync(TblApplicationUser user, Claim claim);




        public Task<IdentityResult> GetAddClaimsAsync(TblApplicationUser user, IEnumerable<Claim> claim);

        public Task<IdentityResult> GetAddLoginAsync(TblApplicationUser user, UserLoginInfo userlogin);

        public Task<IdentityResult> GetAddPasswordAsync(TblApplicationUser user, string pass);

        public Task<IdentityResult> GetAddToRoleAsync(TblApplicationUser user, string role);

        public Task<IdentityResult> GetAddToRolesAsync(TblApplicationUser user, IEnumerable<string> role);

        public Task<IdentityResult> GetChangeEmailAsync(TblApplicationUser user, string newEmail, string token);
        public Task<IdentityResult> GetChangePasswordAsync(TblApplicationUser user, string currentPass, string newPass);
        public Task<IdentityResult> GetChangePhoneNumberAsync(TblApplicationUser user, string changePhoneNumber, string token);
        public Task<bool> GetCheckPasswordAsync(TblApplicationUser user, string checkPassword);
        public Task<IdentityResult> GetConfirmEmailAsync(TblApplicationUser user, string token);
        public Task<int> GetCountRecoveryCodesAsync(TblApplicationUser user);

        #region CreateAsync
        public Task<IdentityResult> PostCreateAsync(TblApplicationUser user);


        public Task<IdentityResult> PostCreateAsync(TblApplicationUser user, string password);

        #endregion
        public Task<byte[]> GetCreateSecurityTokenAsync(TblApplicationUser user);

        //public Task<TblApplicationUser> GetCreateTwoFactorRecoveryCode(TblApplicationUser user);

        public Task<IdentityResult> GetDeleteAsync(TblApplicationUser user);

        //public Task<TblApplicationUser> GetDispose(TblApplicationUser user);;

        //public Task<TblApplicationUser> GetDispose(TblApplicationUser user);;

        public Task<TblApplicationUser?> GetFindByEmailAsync(string email);

        public Task<TblApplicationUser?> GetFindByIdAsync(string userId);

        public Task<TblApplicationUser?> GetFindByLoginAsync(string loginProvider, string providerKey);

        public Task<TblApplicationUser?> GetFindByNameAsync(string userName);

        public Task<string> GetGenerateChangeEmailTokenAsync(TblApplicationUser user, string newEmail);
        public Task<string> GetGenerateChangePhoneNumberTokenAsync(TblApplicationUser user, string phoneNumber);
        public Task<string> GetGenerateConcurrencyStampAsync(TblApplicationUser user);
        public Task<string> GetGenerateEmailConfirmationTokenAsync(TblApplicationUser user);
        //public Task<TblApplicationUser> GetGenerateNewAuthenticatorKey(TblApplicationUser user);
        public Task<IEnumerable<string>?> GetGenerateNewTwoFactorRecoveryCodesAsync(TblApplicationUser user, int number);
        public Task<string> GetGeneratePasswordResetTokenAsync(TblApplicationUser user);
        public Task<string> GetGenerateTwoFactorTokenAsync(TblApplicationUser user, string tokenProvider);
        public Task<string> GetGenerateUserTokenAsync(TblApplicationUser user, string tokenProvider, string purpose);
        public Task<int> GetGetAccessFailedCountAsync(TblApplicationUser user);
        public Task<string?> GetGetAuthenticationTokenAsync(TblApplicationUser user, string loginProvider, string tokenName);
        public Task<string?> GetGetAuthenticatorKeyAsync(TblApplicationUser user);
        //public Task<TblApplicationUser> GetGetChangeEmailTokenPurpose(TblApplicationUser user);
        public Task<IList<Claim>> GetGetClaimsAsync(TblApplicationUser user);
        public Task<string?> GetGetEmailAsync(TblApplicationUser user);
        //public Task<TblApplicationUser> GetGetHashCode(TblApplicationUser user);
        public Task<bool> GetGetLockoutEnabledAsync(TblApplicationUser user);
        public Task<DateTimeOffset?> GetGetLockoutEndDateAsync(TblApplicationUser user);
        public Task<IList<UserLoginInfo>> GetGetLoginsAsync(TblApplicationUser user);
        public Task<string?> GetGetPhoneNumberAsync(TblApplicationUser user);
        public Task<IList<string>> GetGetRolesAsync(TblApplicationUser user);
        public Task<string> GetGetSecurityStampAsync(TblApplicationUser user);
        public Task<bool> GetGetTwoFactorEnabledAsync(TblApplicationUser user);

        //public Task<TblApplicationUser> GetGetType(TblApplicationUser user);


        public Task<TblApplicationUser?> GetGetUserAsync(ClaimsPrincipal claimsPrincipal);


        //public Task<TblApplicationUser> GetGetUserId(ClaimsPrincipal claimsPrincipal);


        public Task<string> GetGetUserIdAsync(TblApplicationUser user);


        //public Task<TblApplicationUser> GetGetUserName(ClaimsPrincipal claimsPrincipal);


        public Task<string?> GetGetUserNameAsync(TblApplicationUser user);


        public Task<IList<TblApplicationUser>> GetGetUsersForClaimAsync(Claim claim);

        public Task<IList<TblApplicationUser>> GetGetUsersInRoleAsync(string roleName);


        public Task<IList<string>> GetGetValidTwoFactorProvidersAsync(TblApplicationUser user);


        public Task<bool> GetHasPasswordAsync(TblApplicationUser user);


        public Task<bool> GetIsEmailConfirmedAsync(TblApplicationUser user);


        public Task<bool> GetIsInRoleAsync(TblApplicationUser user, string role);


        public Task<bool> GetIsLockedOutAsync(TblApplicationUser user);


        public Task<bool> GetIsPhoneNumberConfirmedAsync(TblApplicationUser user);


        //public Task<TblApplicationUser> GetNormalizeEmail(string email);


        //public Task<TblApplicationUser> GetNormalizeName(string Namee);


        public Task<IdentityResult> GetRedeemTwoFactorRecoveryCodeAsync(TblApplicationUser user, string code);


        //public Task<TblApplicationUser> GetRegisterTokenProvider(string providerName,IUserTwoFactorTokenProvider<TblApplicationUser> provider);


        public Task<IdentityResult> GetRemoveAuthenticationTokenAsync(TblApplicationUser user, string loginProvider, string tokenName);


        public Task<IdentityResult> GetRemoveClaimAsync(TblApplicationUser user, Claim claim);


        public Task<IdentityResult> Getxyz(TblApplicationUser user, IEnumerable<Claim> claims);


        public Task<IdentityResult> GetRemoveFromRoleAsync(TblApplicationUser user, string role);


        public Task<IdentityResult> GetRemoveFromRolesAsync(TblApplicationUser user, IEnumerable<string> roles);


        public Task<IdentityResult> GetRemoveLoginAsync(TblApplicationUser user, string loginProvider, string providerKey);


        public Task<IdentityResult> GetRemovePasswordAsync(TblApplicationUser user);


        public Task<IdentityResult> GetReplaceClaimAsync(TblApplicationUser user, Claim claim, Claim newClaim);


        public Task<IdentityResult> GetResetAccessFailedCountAsync(TblApplicationUser user);


        public Task<IdentityResult> GetResetAuthenticatorKeyAsync(TblApplicationUser user);


        public Task<IdentityResult> GetResetPasswordAsync(TblApplicationUser user, string token, string newPassword);


        public Task<IdentityResult> GetSetAuthenticationTokenAsync(TblApplicationUser user, string loginProvider, string tokenName, string tokenValue);


        public Task<IdentityResult> GetSetEmailAsync(TblApplicationUser user, string email);


        public Task<IdentityResult> GetSetLockoutEnabledAsync(TblApplicationUser user, bool enabled);


        public Task<IdentityResult> GetSetLockoutEndDateAsync(TblApplicationUser user, DateTimeOffset lockoutEnd);

        public Task<IdentityResult> GetSetPhoneNumberAsync(TblApplicationUser user, string phoneNumber);

        public Task<IdentityResult> GetSetTwoFactorEnabledAsync(TblApplicationUser user, bool enabled);

        public Task<IdentityResult> GetSetUserNameAsync(TblApplicationUser user, string userName);

        //public Task<TblApplicationUser> GetThrowIfDisposed(TblApplicationUser user);

        public Task<IdentityResult> GetUpdateAsync(TblApplicationUser user);

        //public Task<TblApplicationUser> GetUpdateNormalizedEmailAsync(TblApplicationUser user);

        //public Task<TblApplicationUser> GetUpdateNormalizedUserNameAsync(TblApplicationUser user);

        //public Task<IdentityResult> GetUpdatePasswordHash(TblApplicationUser user,string newPassword,bool validatePassword);

        public Task<IdentityResult> GetUpdateSecurityStampAsync(TblApplicationUser user);

        //public Task<IdentityResult> GetUpdateUserAsync(TblApplicationUser user);

        //public Task<IdentityResult> GetValidatePasswordAsync(TblApplicationUser user,string? password);

        //public Task<IdentityResult> GetValidateUserAsync(TblApplicationUser user);

        public Task<bool> GetVerifyChangePhoneNumberTokenAsync(TblApplicationUser user, string token, string phoneNumber);


        //public Task<PasswordVerificationResult> GetVerifyPasswordAsync(IUserPasswordStore<TblApplicationUser> store,TblApplicationUser user,string password);


        public Task<bool> GetVerifyTwoFactorTokenAsync(TblApplicationUser user, string tokenProvider, string token);


        public Task<bool> GetVerifyUserTokenAsync(TblApplicationUser user, string tokenProvider, string purpose, string token);

    }
}
