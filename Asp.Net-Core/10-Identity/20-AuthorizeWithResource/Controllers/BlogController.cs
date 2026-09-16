using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunIdentity.Data;
using RunIdentity.Models.Dto;
using RunIdentity.Models.Entities;
using System.Linq;

namespace RunIdentity.Controllers
{
    [Authorize(Roles ="Admin")]
    public class BlogController : Controller
    {
        private readonly DataBaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IAuthorizationService _authorizationService;

        public BlogController(DataBaseContext context, UserManager<User> userManager, IAuthorizationService authorizationService)
        {
            _context = context;
            _userManager = userManager;
            _authorizationService = authorizationService;
        }

        public IActionResult Index()
        {
            var blogs = _context.Blogs.Include(u=>u.User).Select(p => new BlogDto
            {
                Id = p.Id,
                Title = p.Title,
                Body = p.Body,
                UserName=p.User.UserName
            });
            return View(blogs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogDto blog)
        {
            var user = _userManager.GetUserAsync(User).Result;
            Blog newBlog = new Blog
            {
                Body = blog.Body,
                Title = blog.Title,
                User = user
            };

            _context.Add(newBlog);
            _context.SaveChanges();
            return RedirectToAction("Index") ;
        }

        public IActionResult Edit(long id)
        {
            var blog = _context.Blogs.Include(u=>u.User).Where(u=>u.Id==id).Select(b=>new BlogDto
            {
                Body=b.Body,
                Title = b.Title,
                Id=b.Id,
                UserId=b.UserId,
                UserName =b.User.UserName
            }).FirstOrDefault();

            var result=_authorizationService.AuthorizeAsync(User, blog, "IsblogForUser").Result;
            if (result.Succeeded)
            {
                return View(blog);
            }
            else
            {
                return new ChallengeResult();
            }


            
        }

        [HttpPost]
        public IActionResult Edit(BlogDto blog)
        {
            ///
            return View();
        }
    }
}
