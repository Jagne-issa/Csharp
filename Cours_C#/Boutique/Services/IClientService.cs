using Boutique.Entities;
using System.Collections.Generic;

namespace Boutique.Services
{
    public interface IClientService
    {
        void CreateClient(Client client);
        Client GetClientByPhone(string phone);
        List<Client> GetAllClients();
        List<Client> FilterClientsWithAccounts(bool hasAccount);
        void UpdateClient(Client client);
    }
}
