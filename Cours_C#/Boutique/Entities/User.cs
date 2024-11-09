using Boutique.Entities;

namespace Boutique.Entities
{
    public class User
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        public User(string email, string login, string password, string role, bool isActive)
        {
            Email = email;
            Login = login;
            Password = password;
            Role = role;
            IsActive = isActive;
        }

        public User() { }
    }
}
