using Boutique.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boutique.Repositories
{
    public class UserRepositoryImpl : IUserRepository
    {
        private List<User> users = new List<User>();

        public void Add(User user) => users.Add(user);
        public void Update(User user)
        {
            var existingUser = users.FirstOrDefault(u => u.Email == user.Email);
            if (existingUser != null)
            {
                existingUser.Login = user.Login;
                existingUser.Password = user.Password;
                existingUser.Role = user.Role;
                existingUser.IsActive = user.IsActive;
            }
        }
        public void Delete(User user) => users.Remove(user);
        public User GetById(int id) => id >= 0 && id < users.Count ? users[id] : null;
        public List<User> GetAll() => users;

        public User GetByEmail(string email) => users.FirstOrDefault(u => u.Email == email);
    }
}
