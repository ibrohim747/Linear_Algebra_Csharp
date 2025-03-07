using Linear_Algebra_Csharp.Part_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Algebra_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrant qt1 = new Quadrant();
            qt1.Finding_part(5, 3); //quadrant I
            qt1.Finding_part(-2, 4); //quadrant II
            qt1.Finding_part(-3, -3); //quadrant III
            qt1.Finding_part(4, -1); //quadrant IV
            qt1.Finding_part(0, 5); //quadrant V


            Linear_equation lq = new Linear_equation();
            string b = Convert.ToString(lq.Linear_eq());

            Console.WriteLine(b);
            
            Console.ReadKey();
        }
    }
}
