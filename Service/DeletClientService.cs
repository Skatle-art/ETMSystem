using ETMSystem.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;

namespace ETMSystem.Service
{
    internal class DeletClientService: IDeleteClientService
    {
        private readonly IDeleteClientRepo _deleteRepo;
        public DeletClientService(IDeleteClientRepo deleteClient)
        {
            _deleteRepo = deleteClient;
        }
        public void GetDeleteId(int id)
        {
            _deleteRepo.GetDeleteId(id);
        }
        public void DeleteClient(Client client)
        {
            _deleteRepo.DeleteClient(client);
        }
        
           
        

    }
}
