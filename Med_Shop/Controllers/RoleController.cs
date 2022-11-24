using Med_Shop.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Med_Shop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(string userrole)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(userrole))
            {
                if (await _roleManager.RoleExistsAsync(userrole))
                {
                    msg = "Role [" + userrole + "] already exist!!";
                }
                else
                {
                    IdentityRole r = new IdentityRole(userrole);
                    await _roleManager.CreateAsync(r);
                    msg = "Role [" + userrole + "] has been created successfully!!!!!";
                }
            }
            else
            {
                msg = "Please enter a valid role...!";
            }
            ViewBag.msg = msg;
            return View("Index");
        }

        public IActionResult AssignRole()
        {
            ViewBag.users = _userManager.Users;
            ViewBag.roles = _roleManager.Roles;
            ViewBag.msg = TempData["msg"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(string userdata, string roledata)
        {
            string msg;
            if (!String.IsNullOrEmpty(userdata) && !string.IsNullOrEmpty(roledata))
            {
                ApplicationUser user = await _userManager.FindByEmailAsync(userdata);
                if (user != null)
                {
                    if (await _roleManager.RoleExistsAsync(roledata))
                    {
                        await _userManager.AddToRoleAsync(user, roledata);
                        msg = "Role has been assigned";
                    }
                    else
                    {
                        msg = "Role Alrady Assigned";
                    }
                }
                else
                {
                    msg = "User is not Found";
                }
            }
            else
            {
                msg = "Please Select valid User and Role";
            }
            ViewBag.msg = msg;
            return RedirectToAction("AssignRole");
        }
    }
}