using System;
using System.Collections.Generic;

namespace SW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string[] numbers = str.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> myList = new List<int>();

            foreach (var num in numbers)
            {
                if (int.TryParse(num, out int value))
                    myList.Add(value);
                else
                    Console.WriteLine($"{num} is not a number");
            }

            int count = 1;
            foreach (int n in myList)
            {
                Console.WriteLine($"{count}.  {isPrime(n)}");
                count++;
            }
            Console.Write("Enter currency in ($): ");
            string inp = Console.ReadLine();

            string[] dollar = inp.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> inpList = new List<double>();

            foreach (var num in dollar)
            {
                if (double.TryParse(num, out double value))
                    inpList.Add(value);
                else
                    Console.WriteLine($"{num} is not a value");
            }
            foreach (double n in inpList)
            {
                var (peso, yen) = convertCurrency(n);
                Console.WriteLine($"{"Dollar($)",-12}{"Phil Peso(P)",-15}{"Jpn Yen(Y)",-15}");
                Console.WriteLine($"{n,-12:F2}\t{peso,-15:F2}\t{yen,-20:F2}");

            }

            Console.ReadKey();
        }
        static (double peso, double yen) convertCurrency(double dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;
            return (peso, yen);
        }
        static string isPrime(int num)
        {
            if (num <= 1)
            {
                return $"{num}\t not Prime or Composite";
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return $"{num}\tComposite";
                }
            }
            return $"{num}\tPrime";
        }
    }
}
