// Lesson 7 Task 2 В двумерном массиве целых чисел удалить строку и 
// столбец на пересечении которых расположен наименьший элемент

void PrintEmpty(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(" ");
    }
}
void PrintMatrix(int[,] matrix, int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j]}  ");
            if (matrix[i, j] >= 0 && matrix[i, j] < 10 && n > 1) PrintEmpty(n - 1);
            if (matrix[i, j] >= 10 && matrix[i, j] < 100 && n > 2) PrintEmpty(n - 2);
            if (matrix[i, j] >= 100 && matrix[i, j] < 1000 && n > 3) PrintEmpty(n - 3);
            Console.Write(matrix[i, j] + "  ");
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

int[] MinNumberInArray(int[,] array)
{
    int[] coordinate = new int[3];
    coordinate[2] = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < coordinate[2])
            {
                coordinate[0] = i;
                coordinate[1] = j;
                coordinate[2] = array[i, j];
            }
        }
    }
    return coordinate;
}

int[,] DelStringAndColumn(int[,] array, int[] coordinate)
{
    int[,] NewArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (!(i == coordinate[0]))
        {
            int l = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (!(j == coordinate[1]))
                {
                    NewArray[k, l] = array[i, j];
                    l = l + 1;
                }
            }
            k = k + 1;
        }
    }
    return NewArray;
}

Console.Write("Задайте количество строк в массиве: ");
int numberStrings = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int numberColumns = int.Parse(Console.ReadLine());
int[,] matrix0 = new int[numberStrings, numberColumns];
int[,] matrixInput = FillRandomMatrix(matrix0, 1, 150);
Console.WriteLine("Входной массив: ");
PrintMatrix(matrixInput, 3);
int[] find = MinNumberInArray(matrixInput);
int str = find[0] + 1;
int stol = find[1] + 1;
Console.WriteLine("Искомый элемент " + find[2] + "  строка->" + str + "  столбец->" + stol);
Console.WriteLine("Выходной массив: ");
int[,] matrixCreate = DelStringAndColumn(matrixInput, find);
PrintMatrix(matrixCreate, 3);