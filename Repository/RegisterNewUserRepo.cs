using ETMSystem.Data;
using ETMSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Repository
{
    internal class RegisterNewUserRepo: IRegisterNewUserRepo
    {
        private readonly ETMSystemContext userRegister;
        public RegisterNewUserRepo(ETMSystemContext UserRegister)
        {
            userRegister = UserRegister;
        }
        public void RegisterUser(User user)
        {
            userRegister.Add(user);
            userRegister.SaveChanges();
        }
    }
}
