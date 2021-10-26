using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IUserRepository<T> : IDisposable
        where T : User
    {
        IEnumerable<User> GetUserList();
        IEnumerable<User> GetUsersWithRoles();
        User GetUser(int id);
        void Create(User user);
        void Update(User user);
        void Delete(int id);
        User GetUserWithRoleAndAppointments(string userName);
    }
}
