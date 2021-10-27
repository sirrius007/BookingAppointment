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
    public class DoctorApiController : Controller
    {
        readonly private IDoctorManager _doctorManager;
        public DoctorApiController(IDoctorManager doctorManager)
        {
            _doctorManager = doctorManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                List<IndexDoctorDTO> doctorDTOs = _doctorManager
                    .GetDoctorList()
                    .ToListDoctorDTO();
                return Ok(doctorDTOs);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка отримання даних");
            }
        }
        [HttpPost]
        public IActionResult Create(CreateDoctorDTO doctorDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                if (doctorDTO == null)
                    return BadRequest();
                Doctor doctor = doctorDTO.ToDoctor();
                _doctorManager.CreateDoctor(doctor);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка при створенні нового лікаря");
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult Details(int id)
        {
            try
            {
                DetailsDoctorDTO doctorDTO = _doctorManager.GetDoctor(id).ToDoctorDetailsDTO();
                if (doctorDTO == null)
                    return NotFound();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка при отриманні даних");
            }
        }
        [HttpPut("{id:int}")]
        public IActionResult Edit(int id, EditDoctorDTO doctorDTO)
        {
            try
            {
                if (id != doctorDTO.Id)
                    return BadRequest("не співпадає Id лікаря");
                if (!_doctorManager.IsExist(id))
                    return NotFound($"Лікар з Id = {id} не знайдений");
                Doctor doctor = doctorDTO.ToDoctor();
                _doctorManager.UpdateDoctor(doctor);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка при оновленні даних");
            }
        }
        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            try
            {
                if (!_doctorManager.IsExist(id))
                    return NotFound($"Лікар з Id = {id} не знайдений");
                _doctorManager.RemoveDoctor(id);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Помилка при видаленні даних");
            }
        }
    }           
}
