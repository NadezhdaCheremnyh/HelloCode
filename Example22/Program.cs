// Lesson 6 Task 2 Найти произведение двух матриц 
// 

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
    //Console.WriteLine(matrix.GetLength(0) + "," + matrix.GetLength(1));
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
            //Console.Write($"{matrix[i, j]}  ");
        }
        //Console.WriteLine();
    }
    return matrix;
}

void ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixProduct = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrixProduct[i, j] = 0;
                for (int r = 0; r < matrix1.GetLength(1); r++)
                {
                    matrixProduct[i, j] = matrixProduct[i, j] + (matrix1[i, r] * matrix2[r, j]);
                }
                Console.Write(matrixProduct[i, j] + "  ");
            }
            Console.WriteLine();
        }
        //return matrixProduct;
    }
    else Console.WriteLine("Матрицы не согласованы");
}

int[,] matrixA = new int[3, 4];
int[,] mA = FillRandomMatrix(matrixA, 1, 9);
Console.WriteLine("Матрица А");
PrintMatrix(mA);
int[,] matrixB = new int[4, 5];
int[,] mB = FillRandomMatrix(matrixB, 1, 9);
Console.WriteLine("Матрица В");
PrintMatrix(mB);
Console.WriteLine("Произведение матриц А и В");
ProductMatrix(mA, mB);


