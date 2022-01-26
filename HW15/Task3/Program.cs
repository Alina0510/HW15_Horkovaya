using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            MyMatrix matrix = new MyMatrix(10, 20);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matrix.Matrix[i, j] = random.Next(0, 9);
                }
            }
            matrix.Show();
            Console.WriteLine();
            matrix.ChangeColumns(10);
            matrix.Show();
            Console.WriteLine();
            matrix.ChangeColumns(15);
            matrix.Show();
            Console.WriteLine();
            matrix.ChangeRows(15);
            matrix.Show();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
