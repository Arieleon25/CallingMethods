using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input sum: ");
            mathOps myNum = new mathOps();
            int input = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int results = myNum.Sum(input, input2);

            Console.WriteLine(results);


            Console.WriteLine("Enter input sub: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int input4 = Convert.ToInt32(Console.ReadLine());
            int results2 = myNum.Sub(input3, input4);
            Console.WriteLine(results2);

            Console.WriteLine("Enter input Mult: ");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int input6 = Convert.ToInt32(Console.ReadLine());
            int results3 = myNum.Mult(input5, input6);
            Console.WriteLine(results3);
            Console.ReadLine();
        }
    }
}