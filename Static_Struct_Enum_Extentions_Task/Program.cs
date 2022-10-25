using System;
using Service.Services.Implementations;
using Static_Struct_Enum_Extentions_Task.Helpers;
using static Service.Services.Implementations.Account;

namespace Static_Struct_Enum_Extentions_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            Account account = new Account();
            account.Login("test@code.edu.az", "test12345", CheckRoles(1));



            ////Task_2
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num.calculateFactorial());
        }

        private static string CheckRoles(int process)
        {
            switch (process)
            {
                case (int)Roles.SuperAdmin:
                    return "SuperAdmin";
                    break;
                case (int)Roles.Admin:
                    return "Admin";
                    break;
                case (int)Roles.Member:
                    return "Member";
                    break;
            }
            return "Not exist";
        }
    }
}

