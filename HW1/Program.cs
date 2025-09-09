using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            do
            {
                Console.Write("Enter String: ");
                text = Console.ReadLine();

                string lower = text.ToLower();
                string reversed = "";

                for (int i = lower.Length - 1; i >= 0; i--)
                {
                    reversed += lower[i];
                }
                string output = (lower == reversed) ? "Yes" : "No";
                Console.WriteLine("Original          Reversed          Palindrome");
                Console.WriteLine("{0,-20}{1,-20} {2}", text, reversed, output);
                
            } while (text != "*");
            Console.ReadKey();
        }
    }
}
