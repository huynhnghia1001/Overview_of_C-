using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name ?");
            string str = Console.ReadLine();
            Console.WriteLine("Xin chào" + str);
            Console.ReadKey();
        }
    }
}
