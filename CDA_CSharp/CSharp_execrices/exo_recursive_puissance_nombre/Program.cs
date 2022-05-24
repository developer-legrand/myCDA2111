using System;

namespace exo_recursive_puissance_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("ENTER YOUR FIRST INTEGER :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR SECOND INTEGER :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(xInteger(a, b));

        }

        public static int xInteger(int _a, int _b)
        {
            if (_b == 0)
            {
                return 0;
            }
            else
            {
                return xInteger(_a, _b - 1) * _a;
            }
        }
    
    }
}
