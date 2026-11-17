
using System;

class Program
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Calculate(int[,] matrix)
    {
        int count = 0;
        int product = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j > i && matrix[i, j] > 0 &&
                    matrix[i, j] % 2 == 0)
                {
                    product *= matrix[i, j];
                    count++;
                }
            }
        }

        if (count > 0)
        {
            Console.WriteLine("Elementter sany: " + count);
            Console.WriteLine("Kobeitindisi: " + product);
        }
        else
        {
            Console.WriteLine("Jup on elementter joq.");
        }
    }

    static void Main()
    {
        int nomer = 12;
        int[,] matrix = new int[5, 5];

        Random rnd = new Random(nomer);

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = rnd.Next(-10, 11);
            }
        }

        Console.WriteLine("Bastapky matrix:");
        PrintMatrix(matrix);

        Calculate(matrix);
    }
}
