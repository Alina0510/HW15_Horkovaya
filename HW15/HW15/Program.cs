using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(0, 9);
                if (array[i] % 2 == 1)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            Console.WriteLine();
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            avg = (double)sum / N;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
