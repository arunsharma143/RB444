using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RB444.Core.IServices;
using RB444.Core.ServiceHelper;
using RB444.Data.Entities;
using RB444.Data.Repository;
using RB444.Models.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RB444.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;
        private readonly IRequestServices _requestServices;
        private readonly IConfiguration _configuration;
        private readonly IBaseRepository _baseRepository;
        private readonly ICookieService _cookieService;
        CommonFun commonFun = new CommonFun();

        public AccountController(UserManager<Users> userManager, SignInManager<Users> signInManager, IRequestServices requestServices, IConfiguration configuration, IBaseRepository baseRepository, ICookieService cookieService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _requestServices = requestServices;
            _configuration = configuration;
            _baseRepository = baseRepository;
            _cookieService = cookieService;
        }
        public async Task<ActionResult> Login(string returnUrl = null)
        {
            try
            {
                var commonModel = await _requestServices.GetAsync<CommonReturnResponse>(String.Format("{0}Common/GetLogo", _configuration["ApiKeyUrl"]));
                Logo logo = jsonParser.ParsJson<Logo>(Convert.ToString(commonModel.Data));
                ViewBag.Logo = logo.FilePath;               
            }
            catch (Exception ex)
            {
                
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(Model.ViewModel.LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        //HttpContext.Session.SetString("loginUserId", user.Id.ToString());
                        //HttpContext.Session.SetString("loginUserFullName", user.FullName);                        
                        //HttpContext.Session.SetString("loginUserRoleId", user.RoleId.ToString());

                        _cookieService.Set("loginUserDetail", JsonConvert.SerializeObject(user), 0);

                        string ipAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                        if (ipAddress != "::1")
                        {
                            var locationModel = commonFun.GetIpInfo(ipAddress);
                            try
                            {
                                var activityLog = new ActivityLog
                                {
                                    Address = $"{locationModel.city}/{locationModel.regionName}/{locationModel.country}/{locationModel.zip}",
                                    IpAddress = locationModel.query,
                                    ISP = locationModel.isp,
                                    LoginDate = DateTime.Now,
                                    UserId = user.Id,
                                    Status = "login_success"
                                };
                                var _result = await _baseRepository.InsertAsync(activityLog);
                                if (_result > 0) { _baseRepository.Commit(); } else { _baseRepository.Rollback(); }
                            }
                            catch (Exception ex)
                            {
                                var activityLog = new ActivityLog
                                {
                                    Address = $"{locationModel.city}/{locationModel.regionName}/{locationModel.country}/{locationModel.zip}",
                                    IpAddress = locationModel.query,
                                    ISP = locationModel.isp,
                                    LoginDate = DateTime.Now,
                                    UserId = user.Id,
                                    Status = "login_fail"
                                };
                                var _result = await _baseRepository.InsertAsync(activityLog); 
                                if (_result > 0) { _baseRepository.Commit(); } else { _baseRepository.Rollback(); }
                            }
                        }

                        return Redirect("/Home/Index");
                    }
                }
                return View(model);
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            var contextUser = HttpContext.User;
            CommonReturnResponse commonModel = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //// Get auth key from web.config
                    //string authKey = WebConfigurationManager.AppSettings["AuthKey"];

                    //// Encrypt password with specific key
                    //var encryptPassword = General.EncryptString(authKey, model.Password);

                    //var loginUserId = User.Identity.GetUserId();

                    //// Find users
                    var loginUser = await _userManager.FindByEmailAsync(contextUser.Identity.Name);

                    if (loginUser.AssignCoin < model.AssignCoin && loginUser.RoleId != 1)
                    {
                        var message = loginUser.AssignCoin == 0 ? "no coin availble" : $"only {loginUser.AssignCoin}";
                        commonModel = new CommonReturnResponse { Data = null, Message = $"You have {message} coins remaining.", IsSuccess = false, Status = ResponseStatusCode.BADREQUEST };
                        return Json(JsonConvert.SerializeObject(commonModel));
                    }

                    var user = new Users
                    {
                        UserName = model.Email,
                        FullName = model.FullName,
                        Email = model.Email,
                        PhoneNumber = model.PhoneNumber,
                        RoleId = model.RoleId,
                        CreatedDate = DateTime.Now,
                        RollingCommission = model.RollingCommission,
                        AssignCoin = model.AssignCoin,
                        Commision = model.Commision,
                        ExposureLimit = model.ExposureLimit,
                        ParentId = loginUser.Id,
                        Status = 1
                    };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await _requestServices.GetAsync<CommonReturnResponse>(string.Format("{0}Account/UpdateAssignCoin?AssignCoin={1}&LoginUserId={2}", _configuration["ApiKeyUrl"], model.AssignCoin, user.ParentId));

                        await _requestServices.GetAsync<CommonReturnResponse>(string.Format("{0}Account/DepositAssignCoin?AssignCoin={1}&ParentId={2}&UserId={3}&UserRoleId={4}", _configuration["ApiKeyUrl"], model.AssignCoin, user.ParentId, user.Id, model.RoleId));

                        //var data = JsonConvert.SerializeObject(commonModel);
                        commonModel = new CommonReturnResponse { Data = null, Message = MessageStatus.Success, IsSuccess = false, Status = ResponseStatusCode.OK };
                        return Json(JsonConvert.SerializeObject(commonModel));
                    }
                    commonModel = new CommonReturnResponse { Data = null, Message = MessageStatus.Error, IsSuccess = false, Status = ResponseStatusCode.BADREQUEST }; ;
                    return Json(JsonConvert.SerializeObject(commonModel));
                }

                commonModel = new CommonReturnResponse { Data = null, Message = CustomMessageStatus.InvalidModelState, IsSuccess = false, Status = ResponseStatusCode.BADREQUEST };
                return Json(JsonConvert.SerializeObject(commonModel));
            }
            catch
            {
                var errorArr = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                var errorHtml = "<ul>";
                if (errorArr != null && errorArr.Count > 0)
                {
                    foreach (var error in errorArr)
                    {
                        errorHtml += "<li>" + error + "</li>";
                    }
                }

                errorHtml += "</ul>";
                commonModel = new CommonReturnResponse { Data = false, Message = errorHtml, IsSuccess = false, Status = ResponseStatusCode.EXCEPTION };
                return Json(JsonConvert.SerializeObject(commonModel));
            }
        }

        [HttpPost]
        public async Task<ActionResult> ChangePassword(ResetPasswordViewModel model)
        {
            var user = JsonConvert.DeserializeObject<Users>(Request.Cookies["loginUserDetail"]);
            ViewBag.LoginUser = user;

            var data = new CommonReturnResponse();

            var isOldPassword = await _userManager.CheckPasswordAsync(user, model.OldPassword);
            if (isOldPassword)
            {
                var Code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, Code, model.Password);
                if (result.Succeeded)
                {
                    data = new CommonReturnResponse()
                    {
                        Data = result,
                        IsSuccess = true,
                        Message = CustomMessageStatus.resetPwd,
                        Status = ResponseStatusCode.OK
                    };
                    return Json(JsonConvert.SerializeObject(data));
                }

                data = new CommonReturnResponse()
                {
                    Data = result.Errors,
                    IsSuccess = false,
                    Message = result.ToString(),
                    Status = ResponseStatusCode.NOTACCEPTABLE
                };
                return Json(JsonConvert.SerializeObject(data));
            }
            else
            {
                data = new CommonReturnResponse()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = CustomMessageStatus.oldPwd,
                    Status = ResponseStatusCode.NOTACCEPTABLE
                };
                return Json(JsonConvert.SerializeObject(data));
            }

            data = new CommonReturnResponse()
            {
                IsSuccess = false,
                Message = "Something Went Wrong."
            };
            return Json(JsonConvert.SerializeObject(data));

            //CommonReturnResponse commonModel = null;
            //try
            //{
            //    commonModel = await _rqs.PostAsync<ResetPasswordViewModel, CommonReturnResponse>(String.Format("{0}System/Account/ResetPassword", _configuration["ApiUrl"]), model);
            //    var data = JsonConvert.SerializeObject(commonModel);
            //    return Json(data);

            //}
            //catch (Exception ex)
            //{
            //    var data = new CommonReturnResponse()
            //    {
            //        IsSuccess = false,
            //        Message = ex.Message
            //    };
            //    return Json(JsonConvert.SerializeObject(data));
            //}
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            _cookieService.Remove("loginUserDetail");
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
