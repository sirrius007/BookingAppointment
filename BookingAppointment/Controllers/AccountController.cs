using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using BookingAppointment.ExtensionMethods;
using BookingAppointment.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookingAppointment.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserManager _userManager;
        public AccountController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegistrationUserDTO userDTO)
        {
            if (!ModelState.IsValid)
                return View("Registration", userDTO);

            User user;
            try
            {
                user = _userManager.CreateUser(
                    userDTO.UserName,
                    userDTO.ToUser());
            }
            catch (ArgumentException e)
            {
                ModelState.AddModelError("", $"{e.Message}");
                return View("Registration", userDTO);
            }

            await Authenticate(user);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserDTO userDTO)
        {
            if (ModelState.IsValid)
            {
                User user = _userManager.GetLoggedUser(userDTO.UserName, userDTO.Password);
                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некоректний логін та/або пароль");
            }
            return View(userDTO);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult UserDetails()
        {
            DetailsUserDTO userDTO = _userManager.GetUserInfo(User.Identity.Name).ToUserDetailsDTO();
            return View(userDTO);
        }
        [HttpGet]
        public IActionResult Edit()
        {
            EditUserDTO userDTO = _userManager.GetUserByUserName(User.Identity.Name).ToUserEditDTO();
            return View(userDTO);
        }
        [HttpPost]
        public IActionResult Edit(EditUserDTO userDTO)
        {
            User user = userDTO.ToUser();
            _userManager.UpdateUser(user, User.Identity.Name);
            return RedirectToAction("UserDetails");
        }
    }
}
