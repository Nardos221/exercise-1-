using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    public class Exercise1
    {
        public static void Main()
        {
            int num1, num2;
            Console.Write("\n\n");
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Input 1st number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input 2nd number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 == num2)
                    Console.WriteLine(" they are equal");
                else
                    Console.WriteLine("are not equal.\n", num1, num2);
            }
        }
    }
}