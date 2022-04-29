using System;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();
            Console.WriteLine(ValidateIP(ip));
        }

        private static bool ValidateIP(string ip)
        {
            bool isValid = true;
            string[] nums = ip.Split('.');

            if (nums.Length != 4)
            {
                isValid = false;
            }

            foreach (var num in nums)
            {
                if (num.StartsWith('0'))
                {
                    isValid = false;
                }

                if (!byte.TryParse(num, out _))
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
