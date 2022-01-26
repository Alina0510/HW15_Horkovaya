using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyMatrix
    {
        public int[,] Matrix { get; set; }
        public MyMatrix(int rows, int columns)
        {
            Matrix = new int[rows, columns];
        }
        public void ChangeRows(int rows)
        {
            int columns = Matrix.GetLength(1);
            int[,] tempMatrix = new int[rows, columns];
            if (rows < Matrix.GetLength(0))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        tempMatrix[i, j] = Matrix[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        tempMatrix[i, j] = Matrix[i, j];
                    }
                }
            }
            Matrix = tempMatrix;
        }
        public void ChangeColumns(int columns)
        {
            int rows = Matrix.GetLength(0);
            int[,] tempMatrix = new int[rows, columns];
            if (columns < Matrix.GetLength(1))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        tempMatrix[i, j] = Matrix[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        tempMatrix[i, j] = Matrix[i, j];
                    }
                }
            }
            Matrix = tempMatrix;
        }
        public void Show()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
