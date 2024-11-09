using Boutique.Entities;
using Boutique.Services;
using System;
using System.Collections.Generic;

namespace Boutique.Views
{
    public class ClientView
    {
        private readonly IClientService _clientService;

        public ClientView(IClientService clientService)
        {
            _clientService = clientService;
        }

        public void CreateClient()
        {
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Client client = new Client
            {
                Surname = surname,
                Phone = phone,
                Address = address
            };
            _clientService.CreateClient(client);
            Console.WriteLine("Client created successfully!");
        }

        public void ListAllClients()
        {
            List<Client> clients = _clientService.GetAllClients();
            Console.WriteLine("List of Clients:");
            foreach (var client in clients)
            {
                Console.WriteLine($"ID: {client.Id}, Surname: {client.Surname}, Phone: {client.Phone}, Address: {client.Address}");
            }
        }

        public void FindClientByPhone()
        {
            Console.Write("Enter phone number to search: ");
            string phone = Console.ReadLine();
            Client client = _clientService.GetClientByPhone(phone);

            if (client != null)
            {
                Console.WriteLine($"Found Client: {client.Surname}, Phone: {client.Phone}, Address: {client.Address}");
            }
            else
            {
                Console.WriteLine("Client not found.");
            }
        }

        internal void ListClients()
        {
            throw new NotImplementedException();
        }

        internal void SearchClientByPhone()
        {
            throw new NotImplementedException();
        }
    }
}
