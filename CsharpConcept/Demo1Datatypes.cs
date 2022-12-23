using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept
{
    internal class Demo1Datatypes
    {

        //datatypes
        static void Main2(string[] args)
        {
            byte a = 200; //a is register for sbyte - 8 bits of memory

            short b = 2000;

            a = 100;

            int c = 10;

            long d = 99L;

            float e = 10.2F;

            double f = 10.2;

            f = c; //int to double - 32 bit to 64 bit - implicit conversion // no data loss

            // c = f; //double to int - 64 bit to 32 bit - explicit conversion

            double x = 10.8788887;

            int y = (int)x; //double to int - 64 bit to 32 bit - explicit conversion //data loss might happen





            int a1 = 100;
            int b1 = 20;

            int res = a1 - b1;

            Console.WriteLine(res);


            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine(x);
            Console.WriteLine(y);


            int radius = 10; //32 bits of memory


            //calculate area of circle 
            double result = 22.0 / 7 * radius * radius;
            Console.WriteLine(result);

            //Console.WriteLine(22 /7);

            char letter = 'a'; //16 bits of memory 

            string name = "Balaji"; //6*16 bits of memory

            Console.WriteLine(name);

            Console.WriteLine(name.Length);

            Console.WriteLine(name[1]);



        }
    }
}
