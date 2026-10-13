using ETMSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Repository
{
    internal interface ICheckUserLogin
    {
        public bool CheckUser(string Username, string Password);
    }
}
