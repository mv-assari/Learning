using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RunIdentity.Areas.Admin.Models.Dto;
using RunIdentity.Areas.Admin.Models.Dto.Role;
using RunIdentity.Models.Entities;
using System.Linq;

namespace RunIdentity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;

        public RoleController(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.Select(r => new RoleListDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddRoleDto roleDto)
        {
            Role role = new Role
            {
                Name = roleDto.Name,
                Description = roleDto.Description
            };
            var result = _roleManager.CreateAsync(role).Result;
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Role", new { area = "Admin" });
            }
            ViewBag.Error = result.Errors.ToList();
            return View(roleDto);
        }


        //این دوکار رو قبلا برای کاربران انجام دادیم و شبیه اون هست
        //_roleManager.UpdateAsync();
        //_roleManager.DeleteAsync();

        public IActionResult UserInRole(string name)
        {

            var users = _userManager.GetUsersInRoleAsync(name).Result;

            return View(users.Select(u=>new UserListDto
            {
                Id=u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName,
                PhoneNumber = u.PhoneNumber,
            }));
        }
    }
}
