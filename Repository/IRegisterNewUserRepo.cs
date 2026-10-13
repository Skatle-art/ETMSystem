using ETMSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Repository
{
    internal interface IRegisterNewUserRepo
    {
        public void RegisterUser(User user);
    }
}
