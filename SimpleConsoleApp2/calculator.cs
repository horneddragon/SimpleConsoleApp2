using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp2
{
    public class calculator
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static void main()
        {
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = add(a, b);
            Console.WriteLine($"sum is {result}");
        }
    }
}
