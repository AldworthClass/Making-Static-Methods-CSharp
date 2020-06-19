using System;
using System.Drawing;
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
        ///<param name="a"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="b"> A double value representing the length of the second leg of a right triangle.</param>
        ///<returns>A double value representing the length of the hypotenuse of a right triangle.</returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        ///<summary>
        ///This method returns the length of the remaining leg of a right triangle when the hypotenuse and a leg are provided.
        ///</summary>
        ///<param name="a"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="hyp"> A double value representing the length of the hypotenuse of a right triangle.</param>
        ///<returns>A double value representing the length of the remaining leg of a right triangle.</returns>
        public static double GetLeg(double a, double hyp)
        {
            return Math.Sqrt(hyp * hyp - a * a);
        }

        ///<summary>
        ///This method returns the rise (y2-y1) a of two y values provided.
        ///</summary>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two y-values provided.</returns>
        public static double GetRise(double y1, double y2)
        {
            return y2 - y1;
        }

        ///<summary>
        ///This method returns the rise (y2-y1) a of two coordinates provided.
        ///</summary>
        ///<param name="p1"> A Point value representing the first coordinate.</param>
        ///<param name="p2"> A Point value representing the second coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two coordinates provided.</returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y); //lets use the method we know works to calculate the slope.
        }



        ///<summary>
        ///This method returns the run (x2-x1) of two coordinates provided.
        ///</summary>
        ///<param name="p1"> A Point value representing the first coordinate.</param>
        ///<param name="p2"> A Point value representing the second coordinate.</param>
        ///<returns>A double value representing the run (x2-x1) of two coordinates provided.</returns>
        public static double GetRun(Point p1,Point p2 )
        {
            return GetRun(p1.X, p2.X); //lets use the method we know works to calculate the slope.
        }

        ///<summary>
        ///This method returns the run (x2-x1) a of two x values provided.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the rise (x2-x1) of two x-values provided.</returns>
        public static double GetRun(double x1, double x2)
        {
            return x2 - x1;
        }


        ///<summary>
        ///This method returns the distance between 2 coordinates.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the distance between two coordinates provided.</returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return GetHypotenuse(GetRun(x1, x2), GetRise(y1, y2));  //The rise and run are the two legs of a right triangle
        }

        ///<summary>
        ///This method returns the distance between 2 coordinates.
        ///</summary>
        ///<param name="p1"> A Point representing the first coordinate.</param>
        ///<param name="p2"> A Point representing the second coordinate.</param>
        ///<returns>A double value representing the distance between two coordinates provided.</returns>
        public static double GetDistance(Point p1, Point p2)
        {
            return GetDistance(p1.X, p1.Y, p2.X, p2.Y);
        }

        ///<summary>
        ///This method returns the slope of a line passing through two coordinates.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the slope of a line containing the two coordinates provided.</returns>
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            return GetRise(y1, y2) / GetRun(x1, x2);
        }


        ///<summary>
        ///This method returns the slope of a line passing through two coordinates.
        ///</summary>
        ///<param name="p1"> A Point representing the first coordinate.</param>
        ///<param name="p2"> A Point representing the second coordinate.</param>
        ///<returns>A double value representing the slope of a line containing the two coordinates provided.</returns>
        public static double GetSlope(Point p1, Point p2)
        {
            return GetSlope(p1.X, p1.Y, p2.X, p2.Y);
        }

    }
}
