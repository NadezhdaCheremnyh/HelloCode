// Lesson 5 Task 3 Задайте массив вещественных чисел  
// Найдите разницу между максимальным и минимальным элементами массива

double[] CreateArray(int count)
{
    double[] result = new double[count];
    return result;
}
//void FillRandomArray(double[] array, double min, double max)
//{
//    int len = array.Length;
//    for (int i = 0; i < len; i++)
//    {
//        Random rnd = new Random();
//        array[i] = rnd.NextDouble() * (max + min) - min;
//        //array[i] = new Random.NextDouble(min, max);
//    }
//}
void PrintArray(double[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
double CompareMaxWithMin(double[] array)
{
    int len = array.Length;
    double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < len; i++)
    {
        if (array[i] > max) max = array[i];
        else
        {
            if (array[i] < min) min = array[i];
        }
    }
    result = max - min;
    return result;
}
//double[] Arr = CreateArray(10);
//FillRandomArray(Arr, -15.01, 99.99);
double[] Arr = { 53.44, 10.34, 6.99, 997.01, 10.10, -3.99, 9.28, 1.32, 15.15, 0 };
PrintArray(Arr);
Console.Write("Разница между max и min элементами массива -> ");
Console.WriteLine(CompareMaxWithMin(Arr));
