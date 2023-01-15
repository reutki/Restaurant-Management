﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    public class checkuser
    {
        public string Login
        {
            get;
            set;

        }

        public bool IsAdmin { get; }
        public string Status => IsAdmin ? "Admin" : "User";

        public checkuser(string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
