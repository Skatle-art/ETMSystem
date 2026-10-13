using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Repository;
using ETMSystem.Models;

namespace ETMSystem.Service
{
    internal class ReadClientService: IReadClientService
    {
        private readonly IReadClientRepo _readClientRepo;
        public ReadClientService(IReadClientRepo clientRepo)
        {
            _readClientRepo = clientRepo;
        }
        public async Task<List<Client>> GetClientsAsync()
        {
            return await _readClientRepo.GetClientsAsync();
        }
        public List<Client> GetAllClients()
        {
            return _readClientRepo.GetClientsAsync().Result;
        }
    }
}
