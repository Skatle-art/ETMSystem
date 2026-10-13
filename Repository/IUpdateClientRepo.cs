using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;

namespace ETMSystem.Repository
{
    internal interface IUpdateClientRepo
    {
        public Client GetClientById(int clientId);
        public void UpdateClient(Client client);
    }
}
