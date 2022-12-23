

using Math.AreaFormulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.CsharpConcept
{
    public class Demo2_Methods
    {
        static void Main22(string[] args)
        {

            double result = Area.AreaOfRectangle(10, 10);
            Console.WriteLine(result);

            double result1 = Area.AreaOfTriangle(10.2, 65);

            Console.WriteLine("The result is "+result1);

            //int radius = 10;

            //double res = Area.AreaOfCircle(10);
            //Console.WriteLine(res);

            //res = Area.AreaOfCircle(20);
            //Console.WriteLine(res);


            ////base=10.2 , height= 20.5
            //double result = Area.AreaOfRectangle(10.2, 10);
            //Console.WriteLine(result);
        }
    }
}
