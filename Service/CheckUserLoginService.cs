using ETMSystem.Data;
using ETMSystem.Models;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Repository
{
    internal class CheckUserLoginService: ICheckUserLoginService
    {
        private readonly ICheckUserLogin user;
        public CheckUserLoginService(ICheckUserLogin Userservice)
        {
            user = Userservice;
        }
        public bool CheckUser(string Username, string password)
        {     
                return user.CheckUser(Username, password); ;
        }
    }
}
