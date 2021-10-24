using BookingAppointment.Domain.Core;
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
    public class AppointmentController : Controller
    {
        private readonly IAppointmentManager _appointmentManager;
        public AppointmentController(IAppointmentManager appointmentManager)
        {
            _appointmentManager = appointmentManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<IndexAppointmentDTO> appointments = _appointmentManager
                .GetAllAppointments()
                .ToListIndexAppointmentDTO();
            return View(appointments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateAppointmentDTO appointmentDTO = new();
            return View(appointmentDTO);
        }
        [HttpPost]
        public IActionResult Create(CreateAppointmentDTO appointmentDTO)
        {
            Appointment appointment = appointmentDTO.ToAppointment();
            appointment.UserId = 2;
            _appointmentManager.CreateAppointment(appointment);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            DetailsAppointmentDTO appointmentDTO = _appointmentManager.GetAppointment(id).ToDetailsAppointmentDTO();
            return View(appointmentDTO);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            EditAppointmentDTO appointmentDTO = _appointmentManager.GetAppointment(id).ToEditAppointmentDTO();
            return View(appointmentDTO);
        }
        [HttpPost]
        public IActionResult Edit(EditAppointmentDTO appointmentDTO)
        {
            Appointment appointment = appointmentDTO.ToAppoinment();
            appointment.UserId = 2;
            _appointmentManager.UpdateAppointment(appointment);
            return RedirectToAction("Details", new { id = appointmentDTO.Id });
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            RemoveAppointmentDTO appointmentDTO = _appointmentManager.GetAppointment(id).ToRemoveAppointmentDTO();
            return View(appointmentDTO);
        }
        [HttpPost]
        public IActionResult Remove(RemoveAppointmentDTO appointmentDTO)
        {
            Appointment appointment = appointmentDTO.ToAppointment();
            _appointmentManager.RemoveAppointment(appointment);
            return RedirectToAction("Index");
        }
    }
}
