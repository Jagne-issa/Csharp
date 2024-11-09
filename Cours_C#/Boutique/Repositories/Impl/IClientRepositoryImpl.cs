using Boutique.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boutique.Repositories
{
    public class IClientRepositoryImpl : IClientRepository
    {
        private List<Client> clients = new List<Client>();

        public void Add(Client client) => clients.Add(client);
        public void Update(Client client)
        {
            var existingClient = clients.FirstOrDefault(c => c.Phone == client.Phone);
            if (existingClient != null)
            {
                existingClient.Surname = client.Surname;
                existingClient.Address = client.Address;
                existingClient.UserAccount = client.UserAccount;
            }
        }
        public void Delete(Client client) => clients.Remove(client);
        public Client GetById(int id) => id >= 0 && id < clients.Count ? clients[id] : null;
        public List<Client> GetAll() => clients;

        public Client GetByPhone(string phone) => clients.FirstOrDefault(c => c.Phone == phone);
    }
}
