using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ViewModels
{
    public class DetailsAppointmentDTO
    {
        [Display(Name = "Номер запису")]
        public int Id { get; set; }
        [Display(Name = "Час початку")]
        public DateTime StartTime { get; set; }
        [Display(Name = "Час завершення")]
        public DateTime EndTime { get; set; }
        [Display(Name = "Формат проведення")]
        public string FormatOfAppointment { get; set; }
        [Display(Name = "Вартість")]
        public int PriceOfAppointment { get; set; }
        [Display(Name = "Місце проведення")]
        public string PlaceOfAppointment { get; set; }
        [Display(Name = "Підсумок консультації")]
        public string SummaryOfAppointment { get; set; }
    }
}
