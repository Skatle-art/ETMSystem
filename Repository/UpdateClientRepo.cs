using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;
using ETMSystem.Data;

namespace ETMSystem.Repository
{
    internal class UpdateClientRepo : IUpdateClientRepo
    {
        private readonly ETMSystemContext _repo;
        public UpdateClientRepo(ETMSystemContext context)
        {
            _repo = context;

        }
        public Client GetClientById(int clientId)
        {
            var client = _repo.Clients.Find(clientId);
            if (client != null)
            {
                return client;
            }
            throw new ArgumentException("Client not found");
        }
        public void UpdateClient(Client client)
        {
            var existingClient = _repo.Clients.Find(client.ClientId);
            if (existingClient != null)
            {
                existingClient.Name = client.Name;
                existingClient.Surname = client.Surname;
                existingClient.PhoneNo = client.PhoneNo;
                existingClient.Email = client.Email;
                existingClient.Address = client.Address;
                existingClient.JobTitle = client.JobTitle;
                existingClient.EmergencyContact = client.EmergencyContact;
                existingClient.ClientStatus = client.ClientStatus;
                _repo.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Client not found");
            }
        }
    }
}
