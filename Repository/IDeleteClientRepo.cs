using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;

namespace ETMSystem.Repository
{
    internal interface IDeleteClientRepo
    {
        public Client GetDeleteId(int id);
        public void DeleteClient(Client client);

    }
}
