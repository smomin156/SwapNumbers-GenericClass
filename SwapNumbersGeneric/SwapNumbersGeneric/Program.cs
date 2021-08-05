using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbersGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapNumbers<int> objInt = new SwapNumbers<int>();
            Console.WriteLine("Enter a number 1");
            objInt.Var1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            objInt.Var2= Convert.ToInt32(Console.ReadLine());

            objInt.Swap();
            Console.WriteLine("num1= "+objInt.Var1);
            Console.WriteLine("num2= "+objInt.Var2);
            Console.WriteLine("-----string--");
            SwapNumbers<string> objString = new SwapNumbers<string>();
            Console.WriteLine("Enter a string 1");
            objString.Var1 = Console.ReadLine();
            Console.WriteLine("Enter a string 2");
            objString.Var2 = Console.ReadLine();

            objString.Swap();
            Console.WriteLine("string1= " + objString.Var1);
            Console.WriteLine("string2= " + objString.Var2);


            Console.ReadLine();
        }
    }
}
