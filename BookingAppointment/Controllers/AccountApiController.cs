using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using BookingAppointment.ExtensionMethods;
using BookingAppointment.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookingAppointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountApiController : Controller
    {
        private readonly IUserManager _userManager;
        public AccountApiController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public IActionResult Registration(RegistrationUserDTO userDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                User user;
                user = _userManager.CreateUser(
                    userDTO.UserName,
                    userDTO.ToUser());
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Помилка внесення нового запису у базу даних");
            }
        }
        [HttpGet("{userName}")]
        public IActionResult UserDetails(string userName)
        {
            try
            {
                if (userName == null)
                    return BadRequest();
                DetailsUserDTO userDTO = _userManager.GetUserInfo(userName).ToUserDetailsDTO();
                if (userDTO == null)
                    return NotFound();
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Помилка при отриманні даних з бази даних");
            }
        }
        [HttpPut("{userName}")]
        public IActionResult Edit(string userName, EditUserDTO userDTO)
        {
            try
            {
                if (userName == null)
                    return BadRequest();
                User user = userDTO.ToUser();
                _userManager.UpdateUser(user, User.Identity.Name);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка оновлення даних");
            }
        }
    }
}
