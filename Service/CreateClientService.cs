using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;
using ETMSystem.Repository; 

namespace ETMSystem.Service
{
    internal class CreateClientService: ICreateClientService
    {
        private readonly ICreateClientRepo ICreaterepo;
        public CreateClientService(ICreateClientRepo createClientRepo)
        {
            ICreaterepo = createClientRepo;
        }
        public void AddNewClient(Client client)
        {
            ICreaterepo.AddNewClient(client);         
        }
    }
}
