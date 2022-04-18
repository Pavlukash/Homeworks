using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp19
{
    internal class Helper
    {
        public double ValidateInputDouble(string input = "")
        {
            return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double num)
                ? num
                : throw new Exception("Число введи, ебан");
        }

        public int ValidateInputInt(string input = "")
        {
            return int.TryParse(input, out int num)
                ? num
                : throw new Exception("Целое число введи, ебан");
        }


        public string ValidateStringOperatorsInput(string str)
        {
            switch (str)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    return str;
                default:
                    throw new Exception("Это не оператор, дурак");

            }
        }
        public string ValidateStringHigherOrLowerInput(string str)
        {
            switch (str)
            {
                case "+":
                case "-":
                    return str;
                default:
                    throw new Exception("Это не оператор, дурак");

            }
        }
        public void ValidateSymbSpace(char? symb)
        {
            if (symb == null || symb == ' ')
            {
                throw new Exception("а где");
            }
        }

        public long ValidateLong(string input)
        {
            long.TryParse(input, out long num);
            if (num > long.MaxValue) return long.MaxValue;
            return (long)num;
        }
        public int ValidateWorkWithBoundsOfArray(int num)
        {
            if (num < 0)
            {
                throw new Exception("Число должно быть положительным, мань");
            }
            return num;
        }
        public string ValidateStrIsOnlyNums(string str)
        {
            char[] array = str.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (!int.TryParse(array[i].ToString(), out _))
                {
                    throw new Exception("Это не цифра/число");
                }
            }
            return str;
        }
        public string ValidateStrWithoutNums(string str)
        {
            char[] array = str.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i].ToString(), out _))
                {
                    throw new Exception("Здесь не должно быть цифр/чисел");
                }
            }
            return str;
        }
        public int ValidateCount(string input)
        {
            int.TryParse(input, out int num);
            if (num < 1) throw new Exception("Ты вообще знаешь как работает счет?");
            return (num);
        }
        public double ValidatePercent(string input)
        {
            double.TryParse(input, out double result);
            if (result < 0 && result > 100) throw new Exception("Проценты вводятся в диапазоне 0 - 100, чучундра");
            return result;
        }
    }
}
