using System;
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
                string input = Console.ReadLine().ToLower().Trim();

                switch (input)
                {
                    case "sum":
                        int sum = 0;

                        for (int i = 0; i < listOfNumbers.Count; i++)
                            sum += listOfNumbers[i];

                        Console.WriteLine($"Сумма введеных чисел: {sum}\n");
                        break;
                    case "exit":
                        isWorking = false;
                        break;
                    default:

                        if (int.TryParse(input, out int number))
                        {
                            listOfNumbers.Add(number);
                            Console.WriteLine("Число получено.");
                        }
                        else
                        {
                            Console.WriteLine("Нужно ввести число!");
                        }

                        break;
                }
            }
        }
    }
}
