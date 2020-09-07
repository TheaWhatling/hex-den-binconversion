using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1a, A;
            int num1b, num1c, num1d, num1e;

            Console.WriteLine("Insert a number");
            num1a = Console.ReadLine();
            try
            {
                num1b = Convert.ToInt32(num1a);

                num1c = (num1b % 16);
                if (num1c == 10)
                {
                    num1c = "A";
                }
                num1d = (num1b / 16);
                num1e = num1d && num1c;
                Console.WriteLine(num1e);


            }catch
            {
                Console.WriteLine("ERROR");
            }
          
        } 
    }
}
