using System;
using System.Linq;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string romanDigit = Console.ReadLine();
            Console.WriteLine(RomanDecode(romanDigit));
        }

        private static int RomanDecode(string romanDigit)
        {
            int result = 0;
            char[] chars = romanDigit.ToArray();
            int[] nums = new int[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'I': 
                        nums[i] = 1;
                        break;
                    case 'V':
                        nums[i] = 5;
                        break;
                    case 'X':
                        nums[i] = 10;
                        break;
                    case 'L':
                        nums[i] = 50;
                        break;
                    case 'C':
                        nums[i] = 100;
                        break;
                    case 'D':
                        nums[i] = 500;
                        break;
                    case 'M':
                        nums[i] = 1000;
                        break;

                    default:
                        throw new Exception("Ввод содержит неверные символы");
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0 && i != nums.Length - 1)
                {
                    if (nums[i - 1] < nums[i] && (nums[i + 1] == nums[i - 1]))
                    {
                        throw new Exception($"{chars[i + 1]} Не может идти сразу после {chars[i - 1] + chars[i]}");
                    }
                    if (nums[i - 1] < nums[i] && (nums[i] / nums[i - 1]) != 10 && (nums[i] / nums[i - 1]) != 5 && nums[i] != nums[i - 1])
                    {
                        throw new Exception($"Меньшее число, задаваемое перед большим, должно быть меньше его в 5 или 10 раз");
                    }
                }
                if (i <= nums.Length - 4)
                {
                    if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2] && nums[i] == nums[i + 3])
                    {
                        throw new Exception("Один и тот же символ не может повторяться более 3-х раз");
                    }
                }

                if (nums.Length == 1)
                {
                    result += nums[i];
                }
                else if (i != nums.Length - 1)
                {
                    if (nums[i] < nums[i + 1])
                    {
                        result += nums[i + 1] - nums[i];
                    }
                    else if (i != 0) 
                    {
                        if ((nums[i - 1] < nums[i]) && nums[i - 1] >= nums[i + 1])
                        {
                            continue;
                        }
                        else if ((nums[i] >= nums[i + 1]))
                        {
                            result += nums[i];
                        }
                    }
                    else if (nums[i] >= nums[i + 1])
                    {
                        result += nums[i];
                    }
                }
                else if (!(nums[i - 1] < nums[i]))
                {
                    result += nums[i];
                }
            }
            return result;
        }
    }
}
