using System;

namespace ConsoleApp19
{
    internal class Program
    {
        /*Ниже ссылка на задание
        https://www.codewars.com/kata/5966f6343c0702d1dc00004c*/
        private static Helper _helper = new Helper();
        static void Main(string[] args)
        {
            int bill = _helper.ValidateInputInt(Console.ReadLine());
            int[] array = new int[6];
            giveChange(bill, array);
            ArrayOutput(array);
        }
        private static int[] giveChange(int bill, int[] array)
        {
            if ((bill / 100) >= 1)
            {
                array[5] = bill / 100;
                bill = bill - (bill / 100) * 100;
            }
            if ((bill / 50) >= 1)
            {
                array[4] = bill / 50;
                bill = bill - (bill / 50) * 50;
            }
            if ((bill / 20) >= 1)
            {
                array[3] = bill / 20;
                bill = bill - (bill / 20) * 20;
            }
            if ((bill / 10) >= 1)
            {
                array[2] = bill / 10;
                bill = bill - (bill / 10) * 10;
            }
            if ((bill / 5) >= 1)
            {
                array[1] = bill / 5;
                bill = bill - (bill / 5) * 5;
            }
            if ((bill / 1) >= 1)
            {
                array[0] = bill / 1;
                bill = bill - (bill / 1) * 1;
            }
            return array;
        }
        private static void ArrayOutput(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}\t");
        }
    }
}
