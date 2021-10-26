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
        public void UpdateUser(User userUpdated, string userName)
        {
            User userExisted = GetUserByUserName(userName);
            userExisted.FirstName = userUpdated.FirstName;
            userExisted.MiddleName = userUpdated.MiddleName;
            userExisted.LastName = userUpdated.LastName;
            userExisted.DateOfBorn = userUpdated.DateOfBorn;
            userExisted.Phone = userUpdated.Phone;
            userExisted.Email = userUpdated.Email;
            _userRepository.Update(userExisted);
        }
        public void RemoveUser(User user)
        {
            _userRepository.Delete(user.Id);
        }
        public User GetUserByUserName(string userName)
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
        public User GetUserInfo(string userName)
        {
            return _userRepository.GetUserWithRoleAndAppointments(userName);
        }
    }
}
