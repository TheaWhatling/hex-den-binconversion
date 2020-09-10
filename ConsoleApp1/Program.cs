using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1a;
            int num1b, num1c;
            char char1=' ';
            char char2 = ' ';

            Console.WriteLine("Insert a number");
            num1a = Console.ReadLine();
            try
            {
                num1b = Convert.ToInt32(num1a);

                num1c = (num1b % 16);
                if (num1c >= 10)
                {
                    char1 = Convert.ToChar(Convert.ToInt32('A') + num1c - 10);
                    
                }else
                {
                    char1 = Convert.ToChar(Convert.ToString(num1c)); 
                }

                num1c = (num1b / 16);
                if (num1c >= 10)
                {
                    char2 = Convert.ToChar(Convert.ToInt32('A') + num1c - 10);

                }else
                {
                     char2 = Convert.ToChar(Convert.ToString(num1c));
                }
            Console.WriteLine(Convert.ToString(char2)+ Convert.ToString(char1));

            }
            catch
            {
                Console.WriteLine("ERROR");
            }
          
        } 
    }
}
