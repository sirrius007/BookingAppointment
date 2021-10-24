using BookingAppointment.Domain.Core;
using BookingAppointment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ExtensionMethods
{
    public static class AppointmentExtension
    {
        private static IndexAppointmentDTO ToIndexAppointmentDTO(this Appointment appointment)
        {
            if (appointment == null)
                return null;
            IndexAppointmentDTO indexAppointmentDTO = new()
            {
                Id = appointment.Id,
                StartTime = appointment.StartTime,
                EndTime = appointment.EndTime,
                FormatOfAppointment = appointment.FormatOfAppointment,
                PriceOfAppointment = appointment.PriceOfAppointment,
                PlaceOfAppointment = appointment.PlaceOfAppointment,
                SummaryOfAppointment = appointment.SummaryOfAppointment,
            };
            return indexAppointmentDTO;
        }
        public static List<IndexAppointmentDTO> ToListIndexAppointmentDTO(this List<Appointment> appointments)
        {
            if (appointments == null)
                return null;
            return appointments.Select(a => a.ToIndexAppointmentDTO()).ToList();
        }
        public static Appointment ToAppointment(this CreateAppointmentDTO appointmentDTO)
        {
            if (appointmentDTO == null)
                return null;
            Appointment appointment = new()
            {
                StartTime = appointmentDTO.StartTime,
                EndTime = appointmentDTO.EndTime,
                FormatOfAppointment = appointmentDTO.FormatOfAppointment,
                PriceOfAppointment = appointmentDTO.PriceOfAppointment,
                PlaceOfAppointment = appointmentDTO.PlaceOfAppointment,
                SummaryOfAppointment = appointmentDTO.SummaryOfAppointment,
            };
            return appointment;
        }
        public static DetailsAppointmentDTO ToDetailsAppointmentDTO(this Appointment appointment)
        {
            if (appointment == null)
                return null;
            DetailsAppointmentDTO appointmentDTO = new()
            {
                Id = appointment.Id,
                StartTime = appointment.StartTime,
                EndTime = appointment.EndTime,
                FormatOfAppointment = appointment.FormatOfAppointment,
                PriceOfAppointment = appointment.PriceOfAppointment,
                PlaceOfAppointment = appointment.PlaceOfAppointment,
                SummaryOfAppointment = appointment.SummaryOfAppointment,
            };
            return appointmentDTO;
        }
        public static EditAppointmentDTO ToEditAppointmentDTO(this Appointment appointment)
        {
            if (appointment == null)
                return null;
            EditAppointmentDTO appointmentDTO = new()
            {
                Id = appointment.Id,
                StartTime = appointment.StartTime,
                EndTime = appointment.EndTime,
                FormatOfAppointment = appointment.FormatOfAppointment,
                PriceOfAppointment = appointment.PriceOfAppointment,
                PlaceOfAppointment = appointment.PlaceOfAppointment,
                SummaryOfAppointment = appointment.SummaryOfAppointment,
            };
            return appointmentDTO;
        }
        public static Appointment ToAppoinment(this EditAppointmentDTO appointmentDTO)
        {
            if (appointmentDTO == null)
                return null;
            Appointment appointment = new()
            {
                Id = appointmentDTO.Id,
                StartTime = appointmentDTO.StartTime,
                EndTime = appointmentDTO.EndTime,
                FormatOfAppointment = appointmentDTO.FormatOfAppointment,
                PriceOfAppointment = appointmentDTO.PriceOfAppointment,
                PlaceOfAppointment = appointmentDTO.PlaceOfAppointment,
                SummaryOfAppointment = appointmentDTO.SummaryOfAppointment,
            };
            return appointment;
        }
        public static RemoveAppointmentDTO ToRemoveAppointmentDTO(this Appointment appointment)
        {
            if (appointment == null)
                return null;
            RemoveAppointmentDTO appointmentDTO = new()
            {
                Id = appointment.Id,
                StartTime = appointment.StartTime,
                EndTime = appointment.EndTime,
                FormatOfAppointment = appointment.FormatOfAppointment,
                PriceOfAppointment = appointment.PriceOfAppointment,
                PlaceOfAppointment = appointment.PlaceOfAppointment,
                SummaryOfAppointment = appointment.SummaryOfAppointment,
            };
            return appointmentDTO;
        }
        public static Appointment ToAppointment(this RemoveAppointmentDTO appointmentDTO)
        {
            if (appointmentDTO == null)
                return null;
            Appointment appointment = new()
            {
                Id = appointmentDTO.Id,
                StartTime = appointmentDTO.StartTime,
                EndTime = appointmentDTO.EndTime,
                FormatOfAppointment = appointmentDTO.FormatOfAppointment,
                PriceOfAppointment = appointmentDTO.PriceOfAppointment,
                PlaceOfAppointment = appointmentDTO.PlaceOfAppointment,
                SummaryOfAppointment = appointmentDTO.SummaryOfAppointment,
            };
            return appointment;
        }
    }
}