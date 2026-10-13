using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;

namespace ETMSystem.Service
{
    internal interface IUpdateClientService
    {
        public Client GetClientById (int ClientId);
        public void UpdateClient(Client client);
    }
}
