using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCamparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Camparison Computation problem");
            double x1, y1,x2,y2;
            double lenght = 0;
            Console.WriteLine("Enter Starting point of line x1 and y1 ordinate");
            x1 =Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter End point of line x2 and y2 ordinate");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            double powx = Math.Pow(x2-x1, 2);
            double powy = Math.Pow(y2-y1, 2);
            lenght = Math.Sqrt(powx + powy);
            Console.WriteLine("Lenght of line is " + lenght);
            Console.ReadKey();
        }
    }
}
