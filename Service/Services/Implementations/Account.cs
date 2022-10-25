using System;
using Service.Services.Interfaces;

namespace Service.Services.Implementations
{
    public class Account : IAccount
    {
        public enum Roles
        {
            SuperAdmin = 1,
            Admin,
            Member
        }

        public void Login(string email, string password, string role)
        {
            if (email == "test@code.edu.az" && password == "test12345" && role == "SuperAdmin")
            {
                Console.WriteLine("Allowed");
            }else if((email != "test@code.edu.az" || password != "test12345") && role == "SuperAdmin")
            {
                Console.WriteLine("Email or Password is wrong");
            }else if ((email == "test@code.edu.az" || password == "test12345") && role != "SuperAdmin")
            {
                Console.WriteLine("The Role is false");
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
    }
}

