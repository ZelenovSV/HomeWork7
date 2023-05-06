//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

void GenerateArray(int[,] NewArray, int M, int N)
{
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            NewArray[i, j] = new Random().Next(0, 10);
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

void Average(int[,] NewArray, int M, int N)
{
Console.WriteLine("Среднее арифметическое элементов в столбцах:");
    for (int j = 0; j < N; j++)
        {                   
            double Sum = 0;
            double Avr = 0;
            for (int i = 0; i < M; i++)
            {
            Sum = Sum + NewArray[i,j];    
            }
            Avr = Sum/M;
            Console.WriteLine($"{Avr}");
        }
}        

int[,] array = new int[M, N];
GenerateArray(array, M, N);
PrintArray(array);
Average(array, M, N);