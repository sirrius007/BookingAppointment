using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Business.Services
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository<User> _userRepository;
        public UserManager(IUserRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetAllUsers()
        {
            return _userRepository.GetUserList().ToList();
        }
        public void CreateUser(User user)
        {
            _userRepository.Create(user);
        }
        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }
        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
        public void RemoveUser(User user)
        {
            _userRepository.Delete(user.Id);
        }
        private User GetUserByUserName(string userName)
        {
            return _userRepository.GetUserList().FirstOrDefault(u => u.UserName == userName);
        }
        public bool IsExist(string userName)
        {
            return GetUserByUserName(userName) != null ? true : false;
        }
        public User GetLoggedUser(string userName, string password)
        {
            return _userRepository.GetUsersWithRoles()
                        .FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }
    }
}
