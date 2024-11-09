using Boutique.Entities;
using Boutique.Repositories;
using Boutique.Services;
using System.Collections.Generic;
using System.Linq;

namespace Boutique.Services
{
    public class ClientServiceImpl : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientServiceImpl(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void CreateClient(Client client) => _clientRepository.Add(client);

        public Client GetClientByPhone(string phone) => _clientRepository.GetByPhone(phone);

        public List<Client> GetAllClients() => _clientRepository.GetAll();

        public List<Client> FilterClientsWithAccounts(bool hasAccount) =>
            _clientRepository.GetAll().Where(c => hasAccount ? c.UserAccount != null : c.UserAccount == null).ToList();

        public void UpdateClient(Client client) => _clientRepository.Update(client);
    }
}
