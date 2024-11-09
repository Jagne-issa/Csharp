using Boutique.Entities;
using Boutique.Repositories;
using Boutique.Services;
using System.Collections.Generic;

namespace Boutique.Services
{
    public class UserServiceImpl : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserServiceImpl(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user) => _userRepository.Add(user);

        public User GetUserByEmail(string email) => _userRepository.GetByEmail(email);

        public void ActivateUser(User user)
        {
            user.IsActive = true;
            _userRepository.Update(user);
        }

        public void DeactivateUser(User user)
        {
            user.IsActive = false;
            _userRepository.Update(user);
        }

        public List<User> GetAllUsers() => _userRepository.GetAll();
    }

    
}
