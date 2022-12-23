using Math.VolumeFormulae;

namespace Math.Formulae
{
    public class Program
    {
        static void Main(string[] args)
        {
            //calling volume related formula
            //printing my name
            Console.WriteLine("Balaji Dinakaran");

            double result = Volume.VolumeOfSphere(12);
            Console.WriteLine("The volume of sphere is " + result);

            Volume obj = new Volume();


            result = obj.VolumeOfCuboid(10, 10, 10);
            Console.WriteLine(result);

            result = obj.VolumeOfCuboid(20, 20, 20);
            Console.WriteLine(result);

            Console.WriteLine(obj.VolumeOfCuboid(30, 30, 30));

            string authorName = Volume.GetAuthorName();

            Console.WriteLine(authorName);

            obj.Quit(10);

            obj.Quit(20);
        }
    }
}