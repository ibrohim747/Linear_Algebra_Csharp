using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Algebra_Csharp.Part_1._01_Basic_Concepts
{
    internal class Matrix
    {
        public static float[,] MultiplyMatrixByScalar(float[,] matrix, float scalar)
        {
            int rows = matrix.GetLength(0); // Количество строк
            int cols = matrix.GetLength(1); // Количество столбцов
            float[,] result = new float[rows, cols]; // Новая матрица для результата

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar; // Умножаем каждый элемент на скаляр
                }
            }

            return result;
        }
    }
}
