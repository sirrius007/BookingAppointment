using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Infrastructure.Data
{
    public class UserRepository : IUserRepository<User>
    {
        private readonly BookingAppointmentContext _db;
        public UserRepository(BookingAppointmentContext bookingAppointmentContext)
        {
            _db = bookingAppointmentContext;
        }
        public IEnumerable<User> GetUserList()
        {
            return _db.Users.ToList();
        }
        public IEnumerable<User> GetUsersWithRoles()
        {
            return _db.Users.Include(u => u.Role);
        }
        public User GetUser(int id)
        {
            return _db.Users.Find(id);
        }
        public void Create(User patient)
        {
            _db.Users.Add(patient);
            _db.SaveChanges();
        }
        public void Update(User patient)
        {
            _db.Users.Update(patient);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Users.Remove(_db.Users.Find(id));
            _db.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
