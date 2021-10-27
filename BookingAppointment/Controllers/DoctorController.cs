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
    public class DoctorController : Controller
    {
        readonly private IDoctorManager _doctorManager;
        public DoctorController(IDoctorManager doctorManager)
        {
            _doctorManager = doctorManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<IndexDoctorDTO> doctorDTOs = _doctorManager.GetDoctorList().ToListDoctorDTO();
            return View(doctorDTOs);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateDoctorDTO doctorDTO = new();
            return View(doctorDTO);
        }
        [HttpPost]
        public IActionResult Create(CreateDoctorDTO doctorDTO)
        {
            if (!ModelState.IsValid)
                return View("Create", doctorDTO);
            Doctor doctor = doctorDTO.ToDoctor();
            _doctorManager.CreateDoctor(doctor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            DetailsDoctorDTO doctorDTO = _doctorManager.GetDoctor(id).ToDoctorDetailsDTO();
            return View(doctorDTO);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            EditDoctorDTO doctorDTO = _doctorManager.GetDoctor(id).ToDoctorEditDTO();
            return View(doctorDTO);
        }
        [HttpPost]
        public IActionResult Edit(EditDoctorDTO doctorDTO)
        {
            Doctor doctor = doctorDTO.ToDoctor();
            _doctorManager.UpdateDoctor(doctor);
            return RedirectToAction("Details", new { id = doctor.Id });
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            RemoveDoctorDTO doctorDTO = _doctorManager.GetDoctor(id).ToDoctorRemoveDTO();
            return View(doctorDTO);
        }
        [HttpPost]
        public IActionResult Remove(RemoveDoctorDTO doctorDTO)
        {
            _doctorManager.RemoveDoctor(doctorDTO.Id);
            return RedirectToAction("Index");
        }
    }
}
