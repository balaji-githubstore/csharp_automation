using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.AreaFormulae
{
    public class Area
    {
        public static double AreaOfCircle(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        //create a static method for AreaOfTriangle()
        public static double AreaOfTriangle(double base1,double height)
        {
            return (base1 * height) / 2;
        }

        //create a static method for AreaOfTrapezium()
       

    }
}
