using BookingAppointment.Domain.Interfaces;
using BookingAppointment.ExtensionMethods;
using BookingAppointment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleManager _scheduleManager;
        public ScheduleController(IScheduleManager scheduleManager)
        {
            _scheduleManager = scheduleManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<IndexScheduleDTO> scheduleDTOs = _scheduleManager.GetAllSchedules().ToListScheduleDTO();
            return View(scheduleDTOs);
        }
    }
}
