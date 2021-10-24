using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Infrastructure.Data
{
    public class RoleRepository : IRoleRepository<Role>
    {
        private readonly BookingAppointmentContext _db;
        public RoleRepository(BookingAppointmentContext bookingAppointmentContext)
        {
            _db = bookingAppointmentContext;
        }
        public IEnumerable<Role> GetRoleList()
        {
            return _db.Roles.ToList();
        }
        public Role GetRole(int id)
        {
            return _db.Roles.Find(id);
        }
        public void Create(Role role)
        {
            _db.Roles.Add(role);
            _db.SaveChanges();
        }
        public void Update(Role role)
        {
            _db.Roles.Update(role);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Roles.Remove(_db.Roles.Find(id));
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
