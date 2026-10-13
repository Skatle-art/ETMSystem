using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;

namespace ETMSystem.Service
{
    internal interface IReadClientService
    {
        public Task<List<Client>> GetClientsAsync();
    }
}
