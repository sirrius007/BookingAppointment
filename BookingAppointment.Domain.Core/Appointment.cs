using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Core
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string FormatOfAppointment { get; set; }
        public int PriceOfAppointment { get; set; }
        public string PlaceOfAppointment { get; set; }
        public string SummaryOfAppointment { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
