using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCamparison
{
    public abstract class GetInput
    {
        public abstract void GetLineEndPoints();
    }
    class CheckLength : GetInput
    {
        public double x1, y1, x2, y2;
        public static double lenghtFirst = 0;
        public static double lenghtSecond = 0;
        public override void GetLineEndPoints()
        {
            Console.WriteLine("Line Camparison Computation problem");
            Console.WriteLine("First Line");
            Console.WriteLine("Enter Starting point of line x1 and y1 ordinate");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter End point of line x2 and y2 ordinate");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            double powFirst = Math.Pow(x2 - x1, 2);
            double powSecond = Math.Pow(y2 - y1, 2);
            lenghtFirst = Math.Sqrt(powFirst + powSecond);
            Console.WriteLine("Lenght of First line is " + lenghtFirst);

            Console.WriteLine("Second Line");
            Console.WriteLine("Enter Starting point of line x1 and y1 ordinate");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter End point of line x2 and y2 ordinate");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            double powx = Math.Pow(x2 - x1, 2);
            double powy = Math.Pow(y2 - y1, 2);
            lenghtSecond = Math.Sqrt(powx + powy);
            Console.WriteLine("Lenght of Second line is " + lenghtSecond);
        }
        public static void UsingEqualsTo()
        {
            if (lenghtFirst.Equals(lenghtSecond))
                Console.WriteLine("Two lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }
        public static void UsingComapreTo()
        {
            int compare = (lenghtFirst.CompareTo(lenghtSecond));
            if (compare > 0)
                Console.WriteLine("lenght of first line is greater than second line");
            else if (compare < 0)
                Console.WriteLine("lenght of second line is greater than first line");
            else
                Console.WriteLine("Both lines are equal");
        }
    }

}
