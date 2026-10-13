using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;
using ETMSystem.Data;
using Microsoft.EntityFrameworkCore;


namespace ETMSystem.Repository
{
    internal class ReadClientRepo : IReadClientRepo
    {
        private readonly ETMSystemContext Ext;

        public ReadClientRepo(ETMSystemContext EContext) => Ext = EContext;

        public async Task<List<Client>> GetClientsAsync()
        {
            return await Ext.Clients.ToListAsync();
          
        }
    }
}
