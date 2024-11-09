namespace Boutique.Entities
{
    public class Client
    {
        internal object Id;

        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public User UserAccount { get; set; }

        public Client(string surname, string phone, string address, User userAccount)
        {
            Surname = surname;
            Phone = phone;
            Address = address;
            UserAccount = userAccount;
        }

        public Client() { }
    }

    
}
