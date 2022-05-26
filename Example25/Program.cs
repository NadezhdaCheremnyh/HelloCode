// Lesson 8 Task 2 Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов

void PrintMatrixWithSumNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumNumbers = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
            sumNumbers = sumNumbers + matrix[i, j];
        }
        int n = i + 1;
        Console.Write("Сумма элементов строки " + n + ": " + sumNumbers);
        Console.WriteLine();
    }
}

int[,] FillRandomMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

int MinSumNumbersOfString(int[,] array)
{
    int[] minSum = new int[array.GetLength(0)];
    int minInString = 0;
    int minSumma = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSum[i] = minSum[i] + array[i, j];
        }
        if (i == 0) minSumma = minSum[i];
        if (!(i == 0))
        {
            if (minSum[i] < minSumma)
            {
                minInString = i;
                minSumma = minSum[i];
            }
        }
    }

    return minInString;
}

Console.Write("Задайте количество строк в массиве: ");
int numberStrings = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int numberColumns = int.Parse(Console.ReadLine());
int[,] matrixA = new int[numberStrings, numberColumns];
int[,] matrixInput = FillRandomMatrix(matrixA, 1, 100);
Console.WriteLine("Входной массив: ");
PrintMatrixWithSumNumbers(matrixInput);

int min = MinSumNumbersOfString(matrixInput) + 1;
Console.WriteLine("Строка с наименьшей суммой элементов № " + min);
for (int j = 0; j < matrixInput.GetLength(1); j++)
{
    Console.Write($"{matrixInput[min - 1, j]}  ");

}
