using AutoMapper;
using IdentityWithRolesAndPolicy.Data;
using IdentityWithRolesAndPolicy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityWithRolesAndPolicy.Controllers
{
    [Authorize(Policy = "adminAccess")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public AdminController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Users()
        {
            var users = _userManager.Users.ToList();
            var userlist = new List<UserViewModel>();

            foreach(var user in users)
            {
                var u = _mapper.Map<UserViewModel>(user);
                u.Roles = await _userManager.GetRolesAsync(user);
                userlist.Add(u);
            }

            return View(userlist);
        }


        public IActionResult Roles()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }




        [HttpGet]
        [Route("admin/roles/create")]
        public IActionResult CreateRole()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        [Route("admin/roles/create")]
        public async Task<IActionResult> CreateRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Roles");
        }



    }
}
