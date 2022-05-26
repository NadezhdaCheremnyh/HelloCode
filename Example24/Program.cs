// Lesson 8 Task 1 Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
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

int[] SelectionSortDown(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
    return array;
}

int[,] matrixA = new int[3, 5];
int[,] matrixInput = FillRandomMatrix(matrixA, 1, 100);
Console.WriteLine("Входной массив: ");
PrintMatrix(matrixInput);

Console.WriteLine("Выходной массив, упорядоченный по убыванию элементов строк");
int[] arrayOneString = new int[matrixInput.GetLength(1)];
int[] sortArrayOneS = new int[matrixInput.GetLength(1)];
int[,] matrixOutput = new int[3, 5];

for (int i = 0; i < matrixInput.GetLength(0); i++)
{
    for (int j = 0; j < matrixInput.GetLength(1); j++)
    {
        arrayOneString[j] = matrixInput[i, j];
    }
    sortArrayOneS = SelectionSortDown(arrayOneString);
    for (int j = 0; j < matrixInput.GetLength(1); j++)
    {
        matrixOutput[i, j] = sortArrayOneS[j];
    }

}
PrintMatrix(matrixOutput);
