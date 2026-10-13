using ETMSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ETMSystem.Data;


namespace ETMSystem.Repository
{
    internal class CreateClientRepo: ICreateClientRepo
    {
        private readonly ETMSystemContext _clientRepo;
        public CreateClientRepo(ETMSystemContext clientRepo)
        {
            _clientRepo = clientRepo;
        }
        public void AddNewClient(Client client) 
        {
            _clientRepo.Clients.Add(client);
            _clientRepo.SaveChanges();

        }
    }
}
