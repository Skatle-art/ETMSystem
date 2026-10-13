using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;
using ETMSystem.Repository;

namespace ETMSystem.Service
{
    internal class UpdateClientService : IUpdateClientService
    {
        private readonly IUpdateClientRepo _updateClientRepo;
        public UpdateClientService(IUpdateClientRepo updateClientRepo)
        {
            _updateClientRepo = updateClientRepo;
        }
        public Client GetClientById(int clientId)
        {
            return _updateClientRepo.GetClientById(clientId);
        }
        public void UpdateClient(Client client)
        {
            _updateClientRepo.UpdateClient(client);
        }
      
    }
}
