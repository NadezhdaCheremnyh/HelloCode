// Lesson 4 Task 2 Возведите число А в натуральную степень В,
// используя цикл

int DegreeNumber(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    return result;
}
int count = 1;
int n = 3;
int valueA = 0;
int valueB = 0;
while (count < n)
{
    Console.Write("Введите целое число А: ");
    valueA = int.Parse(Console.ReadLine());
    //Console.WriteLine();
    Console.Write("Введите натуральное число B (степень): ");
    valueB = int.Parse(Console.ReadLine());
    if (valueB > 0)
    {
        Console.Write("Произведение числа " + valueA + " в степени " + valueB + " => ");
        Console.WriteLine(DegreeNumber(valueA, valueB));
        count++;
    }
    else Console.WriteLine("Введенное значение не является натуральным");
}
