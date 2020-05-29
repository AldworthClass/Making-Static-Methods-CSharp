using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Static_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimeter = 3 + 4 + MyMethods.GetHypotenuse(3, 4);
            Console.WriteLine($"The perimeter is {perimeter}cm");
            Console.ReadLine();
            
        }
    }
}
