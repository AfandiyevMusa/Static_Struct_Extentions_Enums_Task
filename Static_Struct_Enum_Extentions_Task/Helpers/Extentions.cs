using System;
namespace Static_Struct_Enum_Extentions_Task.Helpers
{
    public static class Extentions
    {
        public static int calculateFactorial(this int num)
        {
            int res = 1;
            for (int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}

