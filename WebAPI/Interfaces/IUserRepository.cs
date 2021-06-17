﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IUserRepository
    {
        User Authenticate(string userName, string password);

        void Register(string userName, string password);

        bool UserAlreadyExists(string userName);
    }
}
 