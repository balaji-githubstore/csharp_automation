using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.VolumeFormulae
{
    public class Volume
    {
        public static double VolumeOfSphere(double radius)
        {
            return (4 * 3.14 * radius * radius * radius) / 3;
        }

        public double VolumeOfCuboid(double length, double width, double height)
        {
            return length * width * height;
        }

        public static double VolumeOfCylinder(double radius, double height)
        {
            return 3.1 * radius * radius * height;
        }

        public static string GetAuthorName()
        {
            return "Balaji Dinakaran";
        }

        public void Quit(int a)
        {

        }

    }
}
