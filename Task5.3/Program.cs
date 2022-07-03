sing System;
using System.Collections.Generic;

namespace Task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            List<int> listOfNumbers = new List<int>();
            Console.WriteLine("sum для сложения\nexit для выхода\n");

            while (isWorking)
            {
                Console.WriteLine("Ожидается ввод числа:");
                string input = Console.ReadLine().ToLower().Trim();

                switch (input)
                {
                    case "sum":
                        Sum(listOfNumbers);
                        break;
                    case "exit":
                        isWorking = false;
                        break;
                    default:
                        GetNumber(input, listOfNumbers);
                        break;
                }
            }
        }

        static void Sum(List<int> listOfNumbers )
        {
            int sum = 0;

            foreach (int number in listOfNumbers)
                sum += number;

            Console.WriteLine($"Сумма введеных чисел: {sum}\n");
        }

        static void GetNumber(string input, List<int> listOfNumbers)
        {
            if (int.TryParse(input, out int number))
            {
                listOfNumbers.Add(number);
                Console.WriteLine("Число получено.");
            }
            else
            {
                Console.WriteLine("Нужно ввести число!");
            }
        }
    }
}
