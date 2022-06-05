// Lesson 7 Task 1 Заполните спирально двумерный массив (n х n). 

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

int[,] FillMatrixSpiral(int n)
{
    int[,] array = new int[n, n];
    int length = array.GetLength(0);
    int count = array.GetLength(0);
    int number = 1;
    int currentIndex = length;
    int sign = 0;
    int k = 0;
    int r = 0;
    int ia = 0;
    int ja = 0;

    for (int m = 0; m < array.GetLength(0); m++)
    {
        if (!(length == 0))
        {
            ia = Math.Abs(k);
            for (int j = r; j < currentIndex; j++)
            {
                ja = Math.Abs(j);
                array[ia, ja] = number;
                number = number + 1;
            }

            if (!(length == 1))
            {
                ja = Math.Abs(currentIndex - 1);
                k = k + 1;
                if (k < 0) currentIndex = currentIndex - 1;

                for (int s = k; s < currentIndex; s++)
                {
                    ia = Math.Abs(s);
                    array[ia, ja] = number;
                    number = number + 1;
                }
                sign = sign + 1;

                if (sign == 1)
                {
                    k = -ja;
                    r = k + 1;
                    currentIndex = length - (currentIndex - 1);
                }
                if (sign == 2)
                {
                    k = ja + 1;
                    r = k;
                    count = count - 1;
                    currentIndex = count;
                    sign = 0;
                }
            }
            length = length - 1;
        }
    }
    return array;
}
Console.Write("Задайте размерность массива: ");
int value = int.Parse(Console.ReadLine());
int[,] matrixSpiral = FillMatrixSpiral(value);
Console.WriteLine("Массив, заполненный спирально: ");
PrintMatrix(matrixSpiral);
