//Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

Console.Write("Введите количество строк М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

void GenerateAndPrintArray(int a, int b)
{
    Random rnd = new Random();
    double[,] array = new double[a, b];
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double N = rnd.Next(-10,10) + Math.Round(rnd.NextDouble() ,1);
            array[i, j] = N;
        }
    }
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}
GenerateAndPrintArray(M,N);