// Lesson 8 Task 4 Сформируйте трехмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента


// Метод печати массива построчно с индексами
void PrintArrayWithIndexes(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("(" + i + "," + j + "," + k + ") " + array[i, j, k] + "  ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

//Формирование 3-мерного массива из неповторяющихся двузначных чисел
int[,,] CreateArrayTwoDigit(int[,,] array)
{
    int min = 10;
    int max = 99;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2) && min <= max; k++)
            {
                array[i, j, k] = min;
                min = min + 1;
            }
        }
    }
    return array;
}

int n3 = 3;
int n2 = 6;
int n1 = 90 / (n3 * n2);

int[,,] matrix = new int[n1, n2, n3];
int[,,] matrixInput = CreateArrayTwoDigit(matrix);
Console.WriteLine("i= " + n1 + "  " + "j= " + n2 + "  " + "k= " + n3);
PrintArrayWithIndexes(matrixInput);
