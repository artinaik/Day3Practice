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
            CheckLength checkLengthobj = new CheckLength();
            checkLengthobj.GetLineEndPoints();
            CheckLength.UsingEqualsTo();
            CheckLength.UsingComapreTo();
            Console.ReadKey();
        }
       
    }
}
