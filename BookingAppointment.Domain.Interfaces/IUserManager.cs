using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IUserManager
    {
        List<User> GetAllUsers();
        void CreateUser(User user);
        User GetUser(int id);
        void UpdateUser(User user);
        void RemoveUser(User user);
        bool IsExist(string userName);
        User GetLoggedUser(string userName, string password);
    }
}
