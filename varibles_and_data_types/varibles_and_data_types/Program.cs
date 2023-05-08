using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varibles_and_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 8;
            float f = 1.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            String a = "a string";

            var x = 10;
            var z = "Hello!";

            int[] vals = new int[5];
            string[] strs = { "one", "two", "three" };

            //Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i, f, d, b, c, a, x, z);
            

            object obj = null;
            Console.WriteLine(obj);

            long bignum;
            bignum = i;

            float i_to_f = (float)i;
            Console.WriteLine("{0}", i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine("{0}", f_to_i);

            Console.ReadKey();
        }
    }
}
