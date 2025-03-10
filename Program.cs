using Linear_Algebra_Csharp.Part_1;
using Linear_Algebra_Csharp.Part_1._01_Basic_Concepts;
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
            float[,] matrix = { { 2, 3, 4 }, { 4, 5, 6 }, { 6, 7, 8 } };
            float scalar = 2;
            Console.WriteLine(matrix[1, 2]); // Выведет 6 (вторая строка, третий столбец)
            float[,] result = Matrix.MultiplyMatrixByScalar(matrix, scalar);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            float[] pointA = { 2.5f, 3.0f };
            float[] pointB = { 5.0f, 7.5f };

            float pointC = 23;

            (float ax, float bx) = Vectors.VectorScaling(pointA, pointC);
            Console.WriteLine($"Δx: {ax}, Δy: {bx}");

            (float dx, float dy) = Vectors.VectorComponents(pointA, pointB);
            Console.WriteLine($"Δx: {dx}, Δy: {dy}");

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
