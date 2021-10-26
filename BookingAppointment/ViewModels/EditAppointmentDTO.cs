using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ViewModels
{
    public class EditAppointmentDTO
    {
        [Display(Name = "Номер запису")]
        public int Id { get; set; }
        [Display(Name = "Час початку")]
        [Required(ErrorMessage = "Не вказано час початку консультації")]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [Display(Name = "Час завершення")]
        [Required(ErrorMessage = "Не вказано час завершення консультації")]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        [Display(Name = "Формат проведення")]
        [Required(ErrorMessage = "Не вказано формат консультації")]
        public string FormatOfAppointment { get; set; }
        [Display(Name = "Вартість")]
        [Required(ErrorMessage = "Не вказано вартість консультації")]
        public int PriceOfAppointment { get; set; }
        [Display(Name = "Місце проведення")]
        [Required(ErrorMessage = "Не вказано місце проведення консультації")]
        public string PlaceOfAppointment { get; set; }
        [Display(Name = "Підсумок консультації")]
        public string SummaryOfAppointment { get; set; }
    }
}
