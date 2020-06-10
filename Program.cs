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
            double distance;
            double perimeter = 3 + 4 + MyMethods.GetHypotenuse(3, 4);
            Console.WriteLine($"The perimeter is {perimeter}cm");
            perimeter = 6 + MyMethods.GetLeg(6, 10) + 10;
            Console.WriteLine($"The perimeter is {perimeter}cm");

            distance = MyMethods.GetDistance(new Point(3, 4), new Point(-1, 2));
            Console.WriteLine($"Distance is: {distance}");

            Console.WriteLine(MyMethods.IsRight(3, 4, 5));
            Console.ReadLine();
            
        }
    }
}
