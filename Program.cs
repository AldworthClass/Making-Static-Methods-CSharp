using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Static_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double hypotenuse, leg, distance, rise, run, slope;
          

            Console.WriteLine("Testing GetHypotenuse(), output should be 5");
            hypotenuse = MyMethods.GetHypotenuse(3, 4);
            Console.WriteLine($"The hypotenuse is {hypotenuse}");
            Console.WriteLine();

            Console.WriteLine("Testing GetLeg(), output should be 8");
            leg = MyMethods.GetLeg(6, 10);
            Console.WriteLine($"The side length is {leg}");
            Console.WriteLine();

            Console.WriteLine("Testing GetDistance(), output should be 4.4721");
            distance = MyMethods.GetDistance(new Point(3, 4), new Point(-1, 2));
            Console.WriteLine($"Distance is: {distance:F4}");
            Console.WriteLine();

            Console.WriteLine("Testing GetRise(), output should be 3");
            rise = MyMethods.GetRise(new Point(1, 2), new Point(-2, 5));
            Console.WriteLine($"Rise is: {rise}");
            Console.WriteLine();

            Console.WriteLine("Testing GetRun(), output should be -3");
            run = MyMethods.GetRun(new Point(1, 2), new Point(-2, 5));
            Console.WriteLine($"Run is: {run}");
            Console.WriteLine();

            Console.WriteLine("Testing GetSlope(), output should be -1");
            slope = MyMethods.GetSlope(new Point(1, 2), new Point(-2, 5));
            Console.WriteLine($"Slope is: {slope}");
            Console.WriteLine();


            Console.ReadLine();
            
        }
    }
}
