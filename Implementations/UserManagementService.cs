using JWT.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT.Api.Implementations
{
    public class UserManagementService : IUserManagementService
    {
        public bool IsValidUser(string userName, string password)
        {
            return true;
        }
    }
}
