// Lesson 5 Task 2 Задайте одномерный массив, заполненный случайными числами  
// Найдите сумму элементов, стоящих на нечетных позициях.

int[] CreateArray(int count)
{
    int[] result = new int[count];
    return result;
}
void FillRandomArray(int[] array, int min, int max)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}
void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int AmountOddPositionArray(int[] array)
{
    int len = array.Length;
    int SumNumbers = 0;
    for (int i = 0; i < len; i++)
    {
        if (i % 2 == 0) SumNumbers = SumNumbers + array[i];
    }
    return SumNumbers;
}
int[] Arr = CreateArray(10);
FillRandomArray(Arr, 1, 100);
PrintArray(Arr);
Console.Write("Сумма элементов, стоящих на нечетных позициях -> ");
Console.WriteLine(AmountOddPositionArray(Arr));
