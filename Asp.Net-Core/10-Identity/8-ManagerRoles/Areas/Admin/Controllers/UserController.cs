using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RunIdentity.Areas.Admin.Models.Dto;
using RunIdentity.Areas.Admin.Models.Dto.Role;
using RunIdentity.Models.Dto;
using RunIdentity.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RunIdentity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.Select(u => new UserListDto
            {
                Id= u.Id,
                FirstName= u.FirstName,
                LastName= u.LastName,
                UserName= u.UserName,
                PhoneNumber= u.PhoneNumber,
                EmailConfirmed= u.EmailConfirmed,
                AccessFailedCount= u.AccessFailedCount
            }).ToList();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RegisterDto register)
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
                return RedirectToAction("Index", "user", new {area="Admin"});
            }

            string message = "";
            foreach (var item in result.Errors.ToList())
            {
                message += item.Description + Environment.NewLine;
            }

            TempData["Message"] = message;
            return View(register);
        }

        public IActionResult Edit(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;

            UserEditDto userEdit = new UserEditDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber
            };

            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(UserEditDto userEdit)
        {
            var user=_userManager.FindByIdAsync(userEdit.Id).Result;

            user.FirstName = userEdit.FirstName;
            user.LastName = userEdit.LastName;
            user.Email = userEdit.Email;
            user.UserName = userEdit.UserName;
            user.PhoneNumber = userEdit.PhoneNumber;
            
            var result = _userManager.UpdateAsync(user).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "user", new { area = "Admin" });
            }

            string message = "";
            foreach (var item in result.Errors.ToList())
            {
                message += item.Description + Environment.NewLine;
            }

            TempData["Message"] = message;
            return View(userEdit);
        }

        public IActionResult Delete(string id)
        {
            var user=_userManager.FindByIdAsync(id).Result;
            var result = _userManager.DeleteAsync(user).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User", new { area = "Admin" });
            }

            return View();
        }

        public IActionResult Detail(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            UserDetailDto userDetail = new UserDetailDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName
            };
            return View(userDetail);
        }

        public IActionResult AddUserRole(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var roles = new List<SelectListItem>(_roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Name
            }).ToList());
            return View(new AddUserRoleDto
            {
                Id=id,
                Roles=roles,
                Email=user.Email,
                UserName=$"{user.FirstName} {user.LastName}",
            });
        }

        [HttpPost]
        public IActionResult AddUserRole(AddUserRoleDto userRoleDto)
        {
            var user=_userManager.FindByIdAsync(userRoleDto.Id).Result;
            var result = _userManager.AddToRoleAsync(user, userRoleDto.Role).Result;

            return RedirectToAction("UserRoles", "User", new {Id=user.Id, area = "Admin" });
        }

        public IActionResult UserRoles(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var roles=_userManager.GetRolesAsync(user).Result;
            return View(roles);
        }
    }
}
