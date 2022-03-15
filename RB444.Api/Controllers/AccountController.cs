using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RB444.Core.IServices;
using RB444.Core.ServiceHelper;
using RB444.Data.Entities;
using RB444.Data.Repository;
using RB444.Models.Model;
using System;
using System.Threading.Tasks;

namespace RB444.Api.Controllers
{
    [Route("api/Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;
        private readonly IAccountService _accountService;
        private readonly IBaseRepository _baseRepository;
        CommonFun commonFun = new CommonFun();
        public AccountController(UserManager<Users> userManager, SignInManager<Users> signInManager, IAccountService accountService, IBaseRepository baseRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _accountService = accountService;
            _baseRepository = baseRepository;
        }

        [AllowAnonymous]
        [HttpPost, Route("Login")]
        public async Task<CommonReturnResponse> Login(LoginViewModel model, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return new CommonReturnResponse { Data = null, Message = CustomMessageStatus.InvalidModelState, IsSuccess = false, Status = ResponseStatusCode.BADREQUEST };
            }
            try
            {
                var user = await _userManager.FindByEmailAsync(model.email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.email, model.password, model.rememberme, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        string ipAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                        if (ipAddress != "::1")
                        {
                            var locationModel = commonFun.GetIpInfo(ipAddress);
                            var activityLog = new ActivityLog
                            {
                                Address = $"{locationModel.city}/{locationModel.regionName}/{locationModel.country}/{locationModel.zip}",
                                IpAddress = locationModel.query,
                                ISP = locationModel.isp,
                                LoginDate = DateTime.Now,
                                UserId = user.Id
                            };

                            var _result = await _baseRepository.InsertAsync(activityLog);
                            if (_result > 0) { _baseRepository.Commit(); } else { _baseRepository.Rollback(); }
                        }

                        var userVM = new UserModel
                        {
                            Id = user.Id,
                            UserName = user.UserName,
                            FullName = user.FullName,
                            Email = user.Email,
                            PhoneNumber = user.PhoneNumber,
                            RoleId = user.RoleId,
                            CreatedDate = user.CreatedDate,
                            RollingCommission = user.RollingCommission,
                            AssignCoin = user.AssignCoin,
                            Commision = user.Commision,
                            ExposureLimit = user.ExposureLimit,
                            ParentId = user.ParentId,
                            Status = user.Status
                        };
                        return new CommonReturnResponse { Data = userVM, Message = CustomMessageStatus.Loginsuccess, IsSuccess = true, Status = ResponseStatusCode.OK };
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return new CommonReturnResponse { Data = null, Message = CustomMessageStatus.InvliadLogin, IsSuccess = false, Status = ResponseStatusCode.BADREQUEST };
                    }
                }
                else
                {
                    return new CommonReturnResponse { Data = null, Message = "Inavalid UserName and Password. Please try again", IsSuccess = false, Status = ResponseStatusCode.NOTFOUND };
                }
            }
            catch (Exception ex)
            {
                //_logger.LogException("Exception : AccountController : Login()", ex);
                return new CommonReturnResponse { Data = false, Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, IsSuccess = false, Status = ResponseStatusCode.EXCEPTION };
            }
        }

        [AllowAnonymous]
        [HttpPost, Route("ResetPassword")]
        public async Task<CommonReturnResponse> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //return View(model);
                return new CommonReturnResponse { Data = model, Message = CustomMessageStatus.InvalidModelState, IsSuccess = false, Status = ResponseStatusCode.NOTACCEPTABLE };
            }

            try
            {
                var user = await _userManager.FindByIdAsync(model.UserId.ToString());
                if (user == null)
                {
                    // Don't reveal that the user does not exist
                    // return RedirectToAction(nameof(ResetPasswordConfirmation));
                    return new CommonReturnResponse { Data = user, Message = CustomMessageStatus.userNotFound, IsSuccess = false, Status = ResponseStatusCode.NOTFOUND };
                }
                var isOldPassword = await _userManager.CheckPasswordAsync(user, model.OldPassword);
                if (isOldPassword)
                {
                    var Code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var result = await _userManager.ResetPasswordAsync(user, Code, model.Password);
                    if (result.Succeeded)
                    {
                        //return RedirectToAction(nameof(ResetPasswordConfirmation));
                        return new CommonReturnResponse { Data = result, Message = CustomMessageStatus.resetPwd, IsSuccess = true, Status = ResponseStatusCode.OK };
                    }
                    return new CommonReturnResponse { Data = result.Errors, Message = result.ToString(), IsSuccess = false, Status = ResponseStatusCode.NOTACCEPTABLE };
                }
                else
                {
                    return new CommonReturnResponse { Data = null, Message = CustomMessageStatus.oldPwd, IsSuccess = false, Status = ResponseStatusCode.NOTACCEPTABLE };
                }
            }
            catch (Exception ex)
            {
                //_logger.LogException("Exception : AccountController : ResetPassword()", ex);
                return new CommonReturnResponse { Data = false, Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, IsSuccess = false, Status = ResponseStatusCode.EXCEPTION };
            }
        }

        [HttpGet, Route("UpdateAssignCoin")]
        public async Task<CommonReturnResponse> UpdateAssignCoin(long AssignCoin, int LoginUserId)
        {
            return await _accountService.UpdateAssignCoinAsync(AssignCoin, LoginUserId);
        }

        [HttpGet, Route("DepositAssignCoin")]
        public async Task<CommonReturnResponse> DepositAssignCoin(long AssignCoin, int ParentId, int UserId, int UserRoleId)
        {
            return await _accountService.DepositAssignCoinAsync(AssignCoin, ParentId, UserId, UserRoleId);
        }

        [HttpGet, Route("GetUserRoles")]
        public async Task<CommonReturnResponse> GetUserRoles()
        {
            return await _accountService.GetUserRolesAsync();
        }

        [HttpGet, Route("GetAllUsers")]
        public async Task<CommonReturnResponse> GetAllUsers()
        {
            return await _accountService.GetAllUsers();
        }

        [HttpGet, Route("GetAllUsersByParentId")]
        public async Task<CommonReturnResponse> GetAllUsersByParentId(int ParentId)
        {
            return await _accountService.GetAllUsersByParentIdAsync(ParentId);
        }
    }
}
