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
        User CreateUser(string userName, User user);
        User GetUser(int id);
        void UpdateUser(User user, string userName);
        void RemoveUser(User user);
        User GetLoggedUser(string userName, string password);
        User GetUserInfo(string userName);
        User GetUserByUserName(string userName);
    }
}
