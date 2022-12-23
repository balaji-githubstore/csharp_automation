

using Math.AreaFormulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.CsharpConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            //10,20,30,40,50

            int[] numbers = new int[5];  //5*32 bits of memory 

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine(numbers[0]);

            double[] arr = new double[3]; //3*64 bits of memory
            arr[0] = 10.2;
            arr[1] = 10;
            arr[2] = 7.2f;

            Console.WriteLine(arr[2]);

            //create an array for loading red,green,yellow
            string[] colors = new string[3];
            colors[0] = "red";
            colors[1] = "yellow";
            colors[2] = "green";

            Console.WriteLine(colors);
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);

            //debug and check the default value 

            int[] arr2 = { 45, 95, 85, 66 };

            Console.WriteLine(arr2[2]);

            bool[] arr3 = { true, false, true, true };

            string[] fruits = { "mango", "orange", "apple" };

            Console.WriteLine(fruits[2]);
        }
    }
}
