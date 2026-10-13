using ETMSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Service
{
    internal interface IDeleteClientService
    {
        public void GetDeleteId(int id);
        public void DeleteClient(Client client);
    }
}
