using System;
using System.Collections.Generic;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int col = int.Parse(Console.ReadLine());

            List<List<double>> numbers = new List<List<double>>();

            for(int i = 0; i < row; i++)
            {
                List<double> cols = new List<double>(new double[col]);
                numbers.Add(cols);
            }

            double sum = 0;
            for(int i = 0; i < row; i++)
            {
                Console.WriteLine($"Row{i + 1}");
                for(int j = 0; j < col; j++)
                {
                    Console.Write($"Enter number {j + 1} : ");
                    double value = double.Parse(Console.ReadLine());
                    numbers[i][j] = value;
                    sum += value;
                }
            }

            Console.WriteLine("The numbers are:");
            for(int i = 0;i <row; i++)
            {
                for(int j = 0;j<col; j++)
                {
                    Console.Write(numbers[i][j]+ " ");
                }
                Console.WriteLine();
            }
            double average = sum / (row * col);
            Console.WriteLine($"Sum : {sum}    Average : {average}");
            Console.ReadKey();
        }
    }
}
