using System;
namespace Service.Services.Interfaces
{
    public interface IAccount
    {
        public void Login(string email, string password, string checkRoles);
    }
}

