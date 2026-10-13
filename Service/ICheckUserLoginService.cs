using ETMSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Repository
{
    internal interface ICheckUserLoginService
    {
        public bool CheckUser(string Username, string Password);
    }
}
