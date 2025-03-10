using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Algebra_Csharp.Part_1
{
    internal class Vectors
    {
        public static (float, float) VectorComponents(float[] corA, float[] corB)
        {
            float deltaX = corB[0] - corA[0];
            float deltaY = corB[1] - corA[1];
            return (deltaX, deltaY);
        }

        public static (float, float) VectorScaling(float[] corA, float corB)
        {
            float res_a = corA[0] * corB;
            float res_b = corA[1] * corB;
            return (res_a, res_b);
        }

        public static (float, float) VectorAddition(float[] corA, float[] corB)
        {
            float res_a = corA[0] + corB[0];
            float res_b = corA[1] + corB[1];
            return (res_a, res_b);
        }

        public static (float, float) VectorSubtraction(float[] corA, float[] corB)
        {
            float res_a = corA[0] - corB[0];
            float res_b = corA[1] - corB[1];
            return (res_a, res_b);
        }
    }
}
