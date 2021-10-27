using BookingAppointment.Domain.Core;
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
    public class AppointmentApiController : Controller
    {
        private readonly IAppointmentManager _appointmentManager;
        public AppointmentApiController(IAppointmentManager appointmentManager)
        {
            _appointmentManager = appointmentManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                List<IndexAppointmentDTO> appointments = _appointmentManager
                .GetAllAppointments()
                .ToListIndexAppointmentDTO();
                return Ok(appointments);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка отримання даних");
            }
        }
        [HttpPost]
        public IActionResult Create(CreateAppointmentDTO appointmentDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                Appointment appointment = appointmentDTO.ToAppointment();
                appointment.UserId = 2;
                _appointmentManager.CreateAppointment(appointment);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка при створенні нового запису на прийом до лікаря");
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult Details(int id)
        {
            try
            {
                DetailsAppointmentDTO appointmentDTO = _appointmentManager
                    .GetAppointment(id)
                    .ToDetailsAppointmentDTO();

                if (appointmentDTO == null)
                    return NotFound();

                return Ok(appointmentDTO);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка отримання даних з бази даних");
            }
        }
        [HttpPut("{id}")]
        public IActionResult Edit(int id, EditAppointmentDTO appointmentDTO)
        {
            try
            {
                Appointment appointment = appointmentDTO.ToAppoinment();
                appointment.UserId = id;
                if (appointment == null)
                    return NotFound($"Запис на прийом з Id = {id} не знайдений");
                _appointmentManager.UpdateAppointment(appointment);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка оновлення даних");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                Appointment appointment = _appointmentManager.GetAppointment(id);
                if (appointment == null)
                    return NotFound($"Не знайдено запис на прийом з id = {id}");
                _appointmentManager.RemoveAppointment(appointment);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка видалення даних");
            }
        }
    }
}
