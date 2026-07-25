using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RunIdentity.Models.Dto;
using RunIdentity.Models.Entities;
using RunIdentity.Serivces;
using System;
using System.Linq;

namespace RunIdentity.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly EmailService _emailService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = new EmailService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterDto register)
        {
            if (ModelState.IsValid == false)
            {
                return View(register);
            }

            User newUser = new User
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.Email
            };

            var result = _userManager.CreateAsync(newUser, register.Password).Result;

            if (result.Succeeded)
            {
                var token=_userManager.GenerateEmailConfirmationTokenAsync(newUser).Result;
                string callBackUrl = Url.Action("ConfirmEmail", "Account", new {UserId=newUser.Id,Token=token},protocol:Request.Scheme);

                string body = $"click link<a href={callBackUrl}>link</a>";

                _emailService.Execute(newUser.Email, body, "active account");

                return RedirectToAction("DisplayEmail");
            }

            string message = "";
            foreach (var item in result.Errors.ToList())
            {
                message += item.Description + Environment.NewLine;
            }

            TempData["Message"] = message;
            return View(register);
        }

        public IActionResult ConfirmEmail(string userId,string token)
        {
            if(userId == null || token == null)
            {
                return BadRequest();
            }

            var user = _userManager.FindByIdAsync(userId).Result;

            var result=_userManager.ConfirmEmailAsync(user, token).Result;
            return RedirectToAction("Login");
        }

        public IActionResult DisplayEmail()
        {
            return View();
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordDto passwordDto)
        {
            if (!ModelState.IsValid)
            {
                return  View(passwordDto);
            }

            var user=_userManager.FindByNameAsync(passwordDto.Email).Result;

            if (user==null|| !_userManager.IsEmailConfirmedAsync(user).Result)
            {
                return View("Error");
            }

            var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;
            string callBackUrl = Url.Action("ResetPassword","Account", new {UserId=user.Id ,Token=token},protocol:Request.Scheme);

            string body = $"for reset password click on link<a href={callBackUrl}>reset password</a>";

            _emailService.Execute(user.Email,body,"resetPassword!!!");
            ViewBag.Message = "send mail for reset password";

            return View();
        }

        public IActionResult ResetPassword(string userId,string token)
        {
            return View(new ResetPasswordDto
            {
                UserId = userId,
                Token = token
            });
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordDto resetPassword)
        {
            if(!ModelState.IsValid)
            {
                return View(resetPassword);
            }

            var user=_userManager.FindByIdAsync(resetPassword.UserId).Result;

            if (user == null)
            {
                return View("Error");
            }

            var result=_userManager.ResetPasswordAsync(user,resetPassword.Token,resetPassword.Password).Result;

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(ResetPasswordSuccess));
            }

            ViewBag.Error = result.Errors;
            return View(resetPassword);
        }

        public IActionResult ResetPasswordSuccess()
        {
            return View();
        }

        public IActionResult Login(string returnUrl = "/")
        {

            return View(new LoginDto
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public IActionResult Login(LoginDto login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = _userManager.FindByNameAsync(login.UserName).Result;

            _signInManager.SignOutAsync();

            var result = _signInManager.PasswordSignInAsync(user, login.Password, login.IsPersistent, true).Result;

            if (result.Succeeded == true)
            {
                return Redirect(login.ReturnUrl);
            }
            if (result.RequiresTwoFactor == true)
            {
                //got to twoFactor page
            }
            if (result.IsLockedOut == true)
            {
                //view error to user and show time to lockedout
            }

            ModelState.AddModelError(string.Empty, "Login Error");

            return View();
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
