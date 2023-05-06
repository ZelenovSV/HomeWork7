//Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер элемента массива: ");
int T = Convert.ToInt32(Console.ReadLine());

void GenerateArray(int[,] NewArray, int M, int N)
{
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            NewArray[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] NewArray)
{
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            Console.Write($"{NewArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] NewArray, int T, int M, int N)
{
    if (T > M * N || T < 0)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"{NewArray[T / M, T % M]}");
    }
}
int[,] array = new int[M, N];
GenerateArray(array, M, N);
PrintArray(array);
FindElement(array, T, M, N);