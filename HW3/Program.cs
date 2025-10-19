using System;
using System.Collections.Generic;

namespace HW3
{
    class Program
    {


        

        static Dictionary<char, int> charRecorder(string input)
        {
            Dictionary<char, int> strList = new Dictionary<char, int>();

            foreach (char input2 in input)
            {
                if (input2 == ' ' || input2 == ',')
                {
                    continue;
                }
                if (strList.ContainsKey(input2))
                {
                    strList[input2]++;
                }
                else
                {
                    strList[input2] = 1;
                }
            }
                return strList;
            
        }
        static void Main()
        {
            Console.Write("Enter string(separate with comma) : ");
            string input = Console.ReadLine();

            string[] word = input.Split(','); 

            

            foreach(var myWord in word)
            {
                string myWord2 = myWord.Trim();

                Dictionary<char, int> list = charRecorder(myWord2);

                Console.Write($"{myWord2} >> ");

                foreach(var kvp in list) {
                    Console.Write($"{kvp.Key} = {kvp.Value}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }

}
