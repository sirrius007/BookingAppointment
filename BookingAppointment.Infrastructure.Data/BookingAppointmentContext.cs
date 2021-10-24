using BookingAppointment.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Infrastructure.Data
{
    public class BookingAppointmentContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public BookingAppointmentContext(DbContextOptions<BookingAppointmentContext> options) : base(options)
        { }
    }
}
