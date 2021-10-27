using BookingAppointment.Domain.Interfaces;
using BookingAppointment.ExtensionMethods;
using BookingAppointment.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleApiController : Controller
    {
        private readonly IScheduleManager _scheduleManager;
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                List<IndexScheduleDTO> scheduleDTOs = _scheduleManager
                    .GetAllSchedules()
                    .ToListScheduleDTO();
                return Ok(scheduleDTOs);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка отримання даних");
            }
        }

    }
}
