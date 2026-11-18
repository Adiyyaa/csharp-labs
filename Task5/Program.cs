
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[5, 5];
        Random random = new Random(12);

        // Матрицаны кездейсоқ сандармен толтыру
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(-10, 11);
            }
        }

        // Матрицаны экранға шығару
        Console.WriteLine("Матрица:");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],5}");
            }

            Console.WriteLine();
        }

        // Негізгі диагональдан жоғары орналасқан
        // оң жұп элементтерді санау және көбейту
        int count = 0;
        long product = 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0 && matrix[i, j] % 2 == 0)
                {
                    count++;
                    product *= matrix[i, j];
                }
            }
        }

        // Нәтижені шығару
        Console.WriteLine();

        if (count > 0)
        {
            Console.WriteLine($"Оң жұп элементтер саны: {count}");
            Console.WriteLine($"Олардың көбейтіндісі: {product}");
        }
        else
        {
            Console.WriteLine("Негізгі диагональдан жоғары оң жұп элементтер табылмады.");
        }
    }
}
