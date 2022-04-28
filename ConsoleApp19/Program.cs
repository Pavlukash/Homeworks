using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApp19
{
    internal class Program
    {
        public static Helper _helper = new Helper();
        static void Main(string[] args)
        {
            Console.WriteLine("Add players count");
            int n = _helper.ValidateCount(Console.ReadLine());
            var inputData = new List<KeyValuePair<int, int>>(n);
            var outputData = new List<string>(n);
            CreateDataForOutput(n, inputData, outputData);
            Output(inputData, outputData);
        }

        private static void CreateDataForOutput(int n, List<KeyValuePair<int, int>> inputData, List<string> outputData)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Add age of player №{i + 1}");
                int age = _helper.ValidateCount(Console.ReadLine());
                Console.WriteLine($"Add handicap of player №{i + 1}");
                int.TryParse(Console.ReadLine(), out int handicap);
                if (handicap < -2 || handicap > 26)
                {
                    throw new Exception("Handicap range can be from -2 to 26");
                }

                inputData.Add(new KeyValuePair<int, int>(age, handicap));

                if (inputData[i].Key >= 55 && inputData[i].Value > 7)
                {
                    outputData.Add("Senior");
                }
                else
                {
                    outputData.Add("Open");
                }
            }
        }

        private static void Output(List<KeyValuePair<int, int>> inputData, List<string> outputData)
        {
            Console.WriteLine("Table of player categories");
            for (int i = 0; i < outputData.Count; i++)
            {
                Console.WriteLine($"Age: {inputData[i].Key}\tHandicap: {inputData[i].Value}\tCategory: {outputData[i]}");
            }
        }
    }
}

