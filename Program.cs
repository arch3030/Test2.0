using System;

namespace _28_03_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            Console.Write("Input a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b : ");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            
            while(x != y)
            {
                if(x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine(x);
            Console.ReadLine();




        }
    }
}
