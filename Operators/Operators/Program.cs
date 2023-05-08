using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4, y = 2;
            String a = "abcd", b = "efgh";

            //Console.WriteLine("----Basic Math ----");
            //Console.WriteLine((x/y)*x);
            //Console.WriteLine(a+b);   

            //Console.WriteLine("----Shorthand ----");
            x++;
            y--;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //a += b;
            //Console.WriteLine(a);

            //Console.WriteLine( x > y && y >= 5);
            //Console.WriteLine(x > y || y >= 5);

            string str = null;
            Console.WriteLine(str ?? "Unknow string");

            //str ??= "New String"; 
            //Console.WriteLine(str);
            //Console.ReadKey();
        }
    }
}
