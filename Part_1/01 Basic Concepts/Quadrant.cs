using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Algebra_Csharp.Part_1
{
    internal class Quadrant
    {
        public void Finding_part(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("quadrant I");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("quadrant II");
            }
            else if (x < 0 && y  < 0)
            {
                Console.WriteLine("quadrant III");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("quadrant IV");
            }
            else { Console.WriteLine("On an axis"); }
        }
    }
}
