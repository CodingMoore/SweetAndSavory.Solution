using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetAndSavory.Models;
using System.Threading.Tasks;
using SweetAndSavory.ViewModels;
using System;

namespace SweetAndSavory.Controllers
{
    public class AccountController : Controller
    {
        private readonly SweetAndSavoryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SweetAndSavoryContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Register()
        {   
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register (RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.ToString() == "Succeeded")
            {
                return RedirectToAction("Login");
            }
            else if(result.ToString() == "Failed : DuplicateUserName")
            {
                ViewBag.NameInUse = true;
                Console.WriteLine(ViewBag.NameInUse);
                return View();
            }
            else
            {
                ViewBag.RegisterFail = true;
                return View();
            }
        }

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.loginFail = true;
                return View();
            }
        }

        [HttpPost]
        public async Task<ActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}