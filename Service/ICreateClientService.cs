using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;

namespace ETMSystem.Service
{
    internal interface ICreateClientService
    {
        public void AddNewClient(Client client);
    }
}
