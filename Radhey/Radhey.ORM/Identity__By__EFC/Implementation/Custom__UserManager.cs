using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Radhey.ORM.Identity__By__EFC.Interface;
using Radhey.DAL.IdentityTables;

using Radhey.Model.CommonModel;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

using Microsoft.EntityFrameworkCore;



namespace Radhey.ORM.Identity__By__EFC.Implementation
{
    public class Custom__UserManager : ICustom__UserManager
    {
        private readonly UserManager<TblApplicationUser> _userManager;
        private readonly SignInManager<TblApplicationUser> _signInManager;




        public Custom__UserManager(
                                 UserManager<TblApplicationUser> userManager
                                , SignInManager<TblApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;

        }



        #region User Registration
        public async Task<IdentityResult> PostCreateAsync(TblApplicationUser user)
        {
            var a = await _userManager.CreateAsync(user);
            return a;
        }


        public async Task<IdentityResult> PostCreateAsync(TblApplicationUser user, string password)
        {
            var a = await _userManager.CreateAsync(user, password);
            return a;
        }

        #endregion




        #region User Login
        public async Task<TblApplicationUser?> GetFindByEmailAsync(string email)
        {
            var a = await _userManager.FindByEmailAsync(email);
            return a;
        }


        public async Task<bool> GetCheckPasswordAsync(TblApplicationUser user, string checkPassword)
        {
            var a = await _userManager.CheckPasswordAsync(user, checkPassword);
            return a;
        }

        #endregion



        #region Use Properties for GetAllUsers

        public async Task<ResponseComModel<object>> GetUser()
        {
            ResponseComModel<object> response = new ResponseComModel<object>();

            var allUser = await _userManager.Users.ToListAsync().ConfigureAwait(false);

            if (allUser == null)
            {
                response.StatusCode = 401;
            }
            else
            {
                response.StatusCode = 200;
                response.Data = allUser;

            }

            return response;
        }







        #endregion


        public async Task<IdentityResult> GetAccessFailedAsync(TblApplicationUser user)
        {
            var a = await _userManager.AccessFailedAsync(user);
            return a;
        }

        public async Task<IdentityResult> GetAddClaimAsync(TblApplicationUser user, Claim claim)
        {
            var a = await _userManager.AddClaimAsync(user, claim);
            return a;
        }


        public async Task<IdentityResult> GetAddClaimsAsync(TblApplicationUser user, IEnumerable<Claim> claim)
        {
            var a = await _userManager.AddClaimsAsync(user, claim);
            return a;
        }
        public async Task<IdentityResult> GetAddLoginAsync(TblApplicationUser user, UserLoginInfo userlogin)
        {
            var a = await _userManager.AddLoginAsync(user, userlogin);
            return a;
        }
        public async Task<IdentityResult> GetAddPasswordAsync(TblApplicationUser user, string pass)
        {
            var a = await _userManager.AddPasswordAsync(user, pass);
            return a;
        }
        public async Task<IdentityResult> GetAddToRoleAsync(TblApplicationUser user, string role)
        {
            var a = await _userManager.AddToRoleAsync(user, role);
            return a;
        }
        public async Task<IdentityResult> GetAddToRolesAsync(TblApplicationUser user, IEnumerable<string> role)
        {
            var a = await _userManager.AddToRolesAsync(user, role);
            return a;
        }
        public async Task<IdentityResult> GetChangeEmailAsync(TblApplicationUser user, string newEmail, string token)
        {
            var a = await _userManager.ChangeEmailAsync(user, newEmail, token);
            return a;
        }
        public async Task<IdentityResult> GetChangePasswordAsync(TblApplicationUser user, string currentPass, string newPass)
        {
            var a = await _userManager.ChangePasswordAsync(user, currentPass, newPass);
            return a;
        }
        public async Task<IdentityResult> GetChangePhoneNumberAsync(TblApplicationUser user, string changePhoneNumber, string token)
        {
            var a = await _userManager.ChangePhoneNumberAsync(user, changePhoneNumber, token);
            return a;
        }

        public async Task<IdentityResult> GetConfirmEmailAsync(TblApplicationUser user, string token)
        {
            var a = await _userManager.ConfirmEmailAsync(user, token);
            return a;
        }
        public async Task<int> GetCountRecoveryCodesAsync(TblApplicationUser user)
        {
            var a = await _userManager.CountRecoveryCodesAsync(user);
            return a;
        }


        public async Task<byte[]> GetCreateSecurityTokenAsync(TblApplicationUser user)
        {
            var a = await _userManager.CreateSecurityTokenAsync(user);
            return a;
        }
        //public async Task<TblApplicationUser> GetCreateTwoFactorRecoveryCode(TblApplicationUser user)
        //{
        //    var a = await _userManager.CreateTwoFactorRecoveryCode();
        //    return a;
        //}

        public async Task<IdentityResult> GetDeleteAsync(TblApplicationUser user)
        {
            var a = await _userManager.DeleteAsync(user);
            return a;
        }
        //public async Task<TblApplicationUser> GetDispose(TblApplicationUser user)
        //{
        //    var a = await _userManager.Dispose();
        //    return a;
        //}
        //public async Task<TblApplicationUser> GetDispose(TblApplicationUser user)
        //{
        //    var a = await _userManager.Dispose(true);
        //    return a;
        //}



        public async Task<TblApplicationUser?> GetFindByIdAsync(string userId)
        {
            var a = await _userManager.FindByIdAsync(userId);
            return a;
        }

        public async Task<TblApplicationUser?> GetFindByLoginAsync(string loginProvider, string providerKey)
        {
            var a = await _userManager.FindByLoginAsync(loginProvider, providerKey);
            return a;
        }

        public async Task<TblApplicationUser?> GetFindByNameAsync(string userName)
        {
            var a = await _userManager.FindByNameAsync(userName);
            return a;
        }

        public async Task<string> GetGenerateChangeEmailTokenAsync(TblApplicationUser user, string newEmail)
        {
            var a = await _userManager.GenerateChangeEmailTokenAsync(user, newEmail);
            return a;
        }
        public async Task<string> GetGenerateChangePhoneNumberTokenAsync(TblApplicationUser user, string phoneNumber)
        {
            var a = await _userManager.GenerateChangePhoneNumberTokenAsync(user, phoneNumber);
            return a;
        }
        public async Task<string> GetGenerateConcurrencyStampAsync(TblApplicationUser user)
        {
            var a = await _userManager.GenerateConcurrencyStampAsync(user);
            return a;
        }
        public async Task<string> GetGenerateEmailConfirmationTokenAsync(TblApplicationUser user)
        {
            var a = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return a;
        }
        //public async Task<TblApplicationUser> GetGenerateNewAuthenticatorKey(TblApplicationUser user)
        //{
        //    var a = await _userManager.GenerateNewAuthenticatorKey();
        //    return a;
        //}
        public async Task<IEnumerable<string>?> GetGenerateNewTwoFactorRecoveryCodesAsync(TblApplicationUser user, int number)
        {
            var a = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, number);
            return a;
        }
        public async Task<string> GetGeneratePasswordResetTokenAsync(TblApplicationUser user)
        {
            var a = await _userManager.GeneratePasswordResetTokenAsync(user);
            return a;
        }
        public async Task<string> GetGenerateTwoFactorTokenAsync(TblApplicationUser user, string tokenProvider)
        {
            var a = await _userManager.GenerateTwoFactorTokenAsync(user, tokenProvider);
            return a;
        }
        public async Task<string> GetGenerateUserTokenAsync(TblApplicationUser user, string tokenProvider, string purpose)
        {
            var a = await _userManager.GenerateUserTokenAsync(user, tokenProvider, purpose);
            return a;
        }
        public async Task<int> GetGetAccessFailedCountAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetAccessFailedCountAsync(user);
            return a;
        }
        public async Task<string?> GetGetAuthenticationTokenAsync(TblApplicationUser user, string loginProvider, string tokenName)
        {
            var a = await _userManager.GetAuthenticationTokenAsync(user, loginProvider, tokenName);
            return a;
        }
        public async Task<string?> GetGetAuthenticatorKeyAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetAuthenticatorKeyAsync(user);
            return a;
        }
        //public async Task<TblApplicationUser> GetGetChangeEmailTokenPurpose(TblApplicationUser user)
        //{
        //    var a = await _userManager.GetChangeEmailTokenPurpose(newEmail);
        //    return a;
        //}
        public async Task<IList<Claim>> GetGetClaimsAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetClaimsAsync(user);
            return a;
        }
        public async Task<string?> GetGetEmailAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetEmailAsync(user);
            return a;
        }
        //public async Task<TblApplicationUser> GetGetHashCode(TblApplicationUser user)
        //{
        //    var a = await _userManager.GetHashCode();
        //    return a;
        //}
        public async Task<bool> GetGetLockoutEnabledAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetLockoutEnabledAsync(user);
            return a;
        }
        public async Task<DateTimeOffset?> GetGetLockoutEndDateAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetLockoutEndDateAsync(user);
            return a;
        }
        public async Task<IList<UserLoginInfo>> GetGetLoginsAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetLoginsAsync(user);
            return a;
        }
        public async Task<string?> GetGetPhoneNumberAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetPhoneNumberAsync(user);
            return a;
        }
        public async Task<IList<string>> GetGetRolesAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetRolesAsync(user);
            return a;
        }
        public async Task<string> GetGetSecurityStampAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetSecurityStampAsync(user);
            return a;
        }
        public async Task<bool> GetGetTwoFactorEnabledAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetTwoFactorEnabledAsync(user);
            return a;
        }

        //public async Task<TblApplicationUser> GetGetType(TblApplicationUser user)
        //{
        //    var a = await _userManager.GetType();
        //    return a;
        //}


        public async Task<TblApplicationUser?> GetGetUserAsync(ClaimsPrincipal claimsPrincipal)
        {
            var a = await _userManager.GetUserAsync(claimsPrincipal);
            return a;
        }


        //public async Task<TblApplicationUser> GetGetUserId(ClaimsPrincipal claimsPrincipal)
        //{
        //    var a = await _userManager.GetUserId(claimsPrincipal);
        //    return a;
        //}


        public async Task<string> GetGetUserIdAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetUserIdAsync(user);
            return a;
        }


        //public async Task<TblApplicationUser> GetGetUserName(ClaimsPrincipal claimsPrincipal)
        //{
        //    var a = await _userManager.GetUserName(claimsPrincipal);
        //    return a;
        //}


        public async Task<string?> GetGetUserNameAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetUserNameAsync(user);
            return a;
        }


        public async Task<IList<TblApplicationUser>> GetGetUsersForClaimAsync(Claim claim)
        {
            var a = await _userManager.GetUsersForClaimAsync(claim);
            return a;
        }


        public async Task<IList<TblApplicationUser>> GetGetUsersInRoleAsync(string roleName)
        {
            var a = await _userManager.GetUsersInRoleAsync(roleName);
            return a;
        }


        public async Task<IList<string>> GetGetValidTwoFactorProvidersAsync(TblApplicationUser user)
        {
            var a = await _userManager.GetValidTwoFactorProvidersAsync(user);
            return a;
        }


        public async Task<bool> GetHasPasswordAsync(TblApplicationUser user)
        {
            var a = await _userManager.HasPasswordAsync(user);
            return a;
        }


        public async Task<bool> GetIsEmailConfirmedAsync(TblApplicationUser user)
        {
            var a = await _userManager.IsEmailConfirmedAsync(user);
            return a;
        }


        public async Task<bool> GetIsInRoleAsync(TblApplicationUser user, string role)
        {
            var a = await _userManager.IsInRoleAsync(user, role);
            return a;
        }


        public async Task<bool> GetIsLockedOutAsync(TblApplicationUser user)
        {
            var a = await _userManager.IsLockedOutAsync(user);
            return a;
        }


        public async Task<bool> GetIsPhoneNumberConfirmedAsync(TblApplicationUser user)
        {
            var a = await _userManager.IsPhoneNumberConfirmedAsync(user);
            return a;
        }


        //public async Task<TblApplicationUser> GetNormalizeEmail(string email)
        //{
        //    var a = await _userManager.NormalizeEmail(email);
        //    return a;
        //}


        //public async Task<TblApplicationUser> GetNormalizeName(string Namee)
        //{
        //    var a = await _userManager.NormalizeName(Namee);
        //    return a;
        //}


        public async Task<IdentityResult> GetRedeemTwoFactorRecoveryCodeAsync(TblApplicationUser user, string code)
        {
            var a = await _userManager.RedeemTwoFactorRecoveryCodeAsync(user, code);
            return a;
        }


        //public async Task<TblApplicationUser> GetRegisterTokenProvider(string providerName,IUserTwoFactorTokenProvider<TblApplicationUser> provider)
        //{
        //    var a = await _userManager.RegisterTokenProvider(providerName, provider);
        //    return a;
        //}


        public async Task<IdentityResult> GetRemoveAuthenticationTokenAsync(TblApplicationUser user, string loginProvider, string tokenName)
        {
            var a = await _userManager.RemoveAuthenticationTokenAsync(user, loginProvider, tokenName);
            return a;
        }


        public async Task<IdentityResult> GetRemoveClaimAsync(TblApplicationUser user, Claim claim)
        {
            var a = await _userManager.RemoveClaimAsync(user, claim);
            return a;
        }


        public async Task<IdentityResult> Getxyz(TblApplicationUser user, IEnumerable<Claim> claims)
        {
            var a = await _userManager.RemoveClaimsAsync(user, claims);
            return a;
        }


        public async Task<IdentityResult> GetRemoveFromRoleAsync(TblApplicationUser user, string role)
        {
            var a = await _userManager.RemoveFromRoleAsync(user, role);
            return a;
        }


        public async Task<IdentityResult> GetRemoveFromRolesAsync(TblApplicationUser user, IEnumerable<string> roles)
        {
            var a = await _userManager.RemoveFromRolesAsync(user, roles);
            return a;
        }


        public async Task<IdentityResult> GetRemoveLoginAsync(TblApplicationUser user, string loginProvider, string providerKey)
        {
            var a = await _userManager.RemoveLoginAsync(user, loginProvider, providerKey);
            return a;
        }


        public async Task<IdentityResult> GetRemovePasswordAsync(TblApplicationUser user)
        {
            var a = await _userManager.RemovePasswordAsync(user);
            return a;
        }


        public async Task<IdentityResult> GetReplaceClaimAsync(TblApplicationUser user, Claim claim, Claim newClaim)
        {
            var a = await _userManager.ReplaceClaimAsync(user, claim, newClaim);
            return a;
        }


        public async Task<IdentityResult> GetResetAccessFailedCountAsync(TblApplicationUser user)
        {
            var a = await _userManager.ResetAccessFailedCountAsync(user);
            return a;
        }


        public async Task<IdentityResult> GetResetAuthenticatorKeyAsync(TblApplicationUser user)
        {
            var a = await _userManager.ResetAuthenticatorKeyAsync(user);
            return a;
        }


        public async Task<IdentityResult> GetResetPasswordAsync(TblApplicationUser user, string token, string newPassword)
        {
            var a = await _userManager.ResetPasswordAsync(user, token, newPassword);
            return a;
        }


        public async Task<IdentityResult> GetSetAuthenticationTokenAsync(TblApplicationUser user, string loginProvider, string tokenName, string tokenValue)
        {
            var a = await _userManager.SetAuthenticationTokenAsync(user, loginProvider, tokenName, tokenValue);
            return a;
        }


        public async Task<IdentityResult> GetSetEmailAsync(TblApplicationUser user, string email)
        {
            var a = await _userManager.SetEmailAsync(user, email);
            return a;
        }


        public async Task<IdentityResult> GetSetLockoutEnabledAsync(TblApplicationUser user, bool enabled)
        {
            var a = await _userManager.SetLockoutEnabledAsync(user, enabled);
            return a;
        }


        public async Task<IdentityResult> GetSetLockoutEndDateAsync(TblApplicationUser user, DateTimeOffset lockoutEnd)
        {
            var a = await _userManager.SetLockoutEndDateAsync(user, lockoutEnd);
            return a;
        }

        public async Task<IdentityResult> GetSetPhoneNumberAsync(TblApplicationUser user, string phoneNumber)
        {
            var a = await _userManager.SetPhoneNumberAsync(user, phoneNumber);
            return a;
        }

        public async Task<IdentityResult> GetSetTwoFactorEnabledAsync(TblApplicationUser user, bool enabled)
        {
            var a = await _userManager.SetTwoFactorEnabledAsync(user, enabled);
            return a;
        }

        public async Task<IdentityResult> GetSetUserNameAsync(TblApplicationUser user, string userName)
        {
            var a = await _userManager.SetUserNameAsync(user, userName);
            return a;
        }

        //public async Task<TblApplicationUser> GetThrowIfDisposed(TblApplicationUser user)
        //{
        //    var a = await _userManager.ThrowIfDisposed();
        //    return a;
        //}

        public async Task<IdentityResult> GetUpdateAsync(TblApplicationUser user)
        {
            var a = await _userManager.UpdateAsync(user);
            return a;
        }

        //public async Task<TblApplicationUser> GetUpdateNormalizedEmailAsync(TblApplicationUser user)
        //{
        //    var a = await _userManager.UpdateNormalizedEmailAsync(user);
        //    return a;
        //}

        //public async Task<TblApplicationUser> GetUpdateNormalizedUserNameAsync(TblApplicationUser user)
        //{
        //    var a = await _userManager.UpdateNormalizedUserNameAsync(user);
        //    return a;
        //}

        //public async Task<IdentityResult> GetUpdatePasswordHash(TblApplicationUser user,string newPassword,bool validatePassword)
        //{
        //    var a = await _userManager.UpdatePasswordHash(user, newPassword, validatePassword);
        //    return a;
        //}

        public async Task<IdentityResult> GetUpdateSecurityStampAsync(TblApplicationUser user)
        {
            var a = await _userManager.UpdateSecurityStampAsync(user);
            return a;
        }

        //public async Task<IdentityResult> GetUpdateUserAsync(TblApplicationUser user)
        //{
        //    var a = await _userManager.UpdateUserAsync(user);
        //    return a;
        //}

        //public async Task<IdentityResult> GetValidatePasswordAsync(TblApplicationUser user,string? password)
        //{
        //    var a = await _userManager.ValidatePasswordAsync(user, password);
        //    return a;
        //}

        //public async Task<IdentityResult> GetValidateUserAsync(TblApplicationUser user)
        //{
        //    var a = await _userManager.ValidateUserAsync(user);
        //    return a;
        //}

        public async Task<bool> GetVerifyChangePhoneNumberTokenAsync(TblApplicationUser user, string token, string phoneNumber)
        {
            var a = await _userManager.VerifyChangePhoneNumberTokenAsync(user, token, phoneNumber);
            return a;
        }

        //public async Task<PasswordVerificationResult> GetVerifyPasswordAsync(IUserPasswordStore<TblApplicationUser> store,TblApplicationUser user,string password)
        //{
        //    var a = await _userManager.VerifyPasswordAsync(store, user, password);
        //    return a;
        //}

        public async Task<bool> GetVerifyTwoFactorTokenAsync(TblApplicationUser user, string tokenProvider, string token)
        {
            var a = await _userManager.VerifyTwoFactorTokenAsync(user, tokenProvider, token);
            return a;
        }

        public async Task<bool> GetVerifyUserTokenAsync(TblApplicationUser user, string tokenProvider, string purpose, string token)
        {
            var a = await _userManager.VerifyUserTokenAsync(user, tokenProvider, purpose, token);
            return a;
        }

    }
}
