// Lesson 5 Task 1 Задайте массив, заполненный случайными положительными  
// трехзначными числами. напишите программу, которая покажет количество
// четных чисел в массиве

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
int EvenNumberArray(int[] array)
{
    int len = array.Length;
    int EvenInteger = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0) EvenInteger = EvenInteger + 1;
    }
    return EvenInteger;
}
int[] Arr = CreateArray(10);
FillRandomArray(Arr, 100, 999);
PrintArray(Arr);
Console.Write("Количество четных чисел в массиве -> ");
Console.WriteLine(EvenNumberArray(Arr));
