using System;
using System.Collections.Generic;
using System.Text;
using ETMSystem.Models;
using ETMSystem.Repository;

namespace ETMSystem.Service
{
    internal class RegisterNewUserService: IRegisterNewUserService
    {
        private readonly IRegisterNewUserRepo userReg;
        public RegisterNewUserService(IRegisterNewUserRepo Userservice)
        {
            userReg = Userservice;
        }
        public void RegisterUser(User user)
        {
            userReg.RegisterUser(user);
        }
    }
}
