using ETMSystem.Data;
using ETMSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETMSystem.Repository
{
    internal class CheckUserLogin: ICheckUserLogin
    {
        private readonly ETMSystemContext UNContext;
        public CheckUserLogin(ETMSystemContext UserContext)
        {
            UNContext = UserContext;
        }
        public bool CheckUser(string username, string password)
        {
            return UNContext.Users.AsNoTracking().Any(u => u.Username == username && u.PasswordHash == password);

        }

    }
}
