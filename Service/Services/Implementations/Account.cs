using System;
using Service.Services.Interfaces;

namespace Service.Services.Implementations
{
    public class Account : IAccount
    {
        public void Login(string email, string password, string role)
        {
            if (email == "test@code.edu.az" && password == "test12345" && role == "SuperAdmin")
            {
                Console.WriteLine("You are logged in!!!");
            }else if((email != "test@code.edu.az" || password != "test12345") && role == "SuperAdmin")
            {
                Console.WriteLine("Email or Password is wrong");
            }else if ((email == "test@code.edu.az" || password == "test12345") && role != "SuperAdmin")
            {
                Console.WriteLine("Only the Role OR Role and at the same time, email or password is false");
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
    }
}

