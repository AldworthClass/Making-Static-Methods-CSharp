using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Static_Methods
{
    static class MyMethods
    {

        ///<summary>
        ///This method returns the length of the hypotenuse of a right triangle when two legs are provided.
        ///</summary>
        ///<param name="a"> A double value representing one of a leg a right triangle.</param>
        ///<param name="b"> A double value representing the second leg a right triangle.</param>
        ///<returns>A double value representing the hypotenuse of the right triangle</returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }


    }
}
