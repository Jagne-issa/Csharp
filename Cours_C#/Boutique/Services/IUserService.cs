using Boutique.Entities;

namespace Boutique.Services
{
    public interface IUserService
    {
        void CreateUser(User user);
        User GetUserByEmail(string email);
        void ActivateUser(User user);
        void DeactivateUser(User user);
        List<User> GetAllUsers();
    }
}
