using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORIAL
{
    class Program
    {
        long Factorial(long X)
        {
            long FX = 1;
            if (X > 1) FX = Factorial(X - 1) * X;
            return FX;
        }

        static void Main(string[] args)
        {
            long F;
            Console.Write("\n n! = ");
            F = long.Parse(Console.ReadLine());
            Program n = new Program();

            for (long R = 0; R <= F; R++)
            { 
                Console.WriteLine(" Factorial ke {0} = {1}",R,n.Factorial(R));
            }
            Console.ReadKey();
        }
    }
}
