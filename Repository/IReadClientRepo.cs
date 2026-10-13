using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;

namespace ETMSystem.Repository
{
    internal interface IReadClientRepo
    {
        Task<List<Client>> GetClientsAsync();
    }
}
