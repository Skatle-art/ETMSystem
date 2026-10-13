using ETMSystem.Data;
using ETMSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Repository
{
    internal class DeleteClientRepocs: IDeleteClientRepo
    {
        private readonly ETMSystemContext _context;
        public DeleteClientRepocs(ETMSystemContext deleteClient)
        {
              _context = deleteClient;
        }
        public Client GetDeleteId(int clientId)
        {
            var ClientToDelete = _context.Clients.Find(clientId);
            if (ClientToDelete == null)
            {
                throw new Exception("Client Not Found");
            }
            else
            return ClientToDelete;
        }
        public void DeleteClient(Client client)
        {
            _context.Clients.Remove(client);
            
        }
    }
}
