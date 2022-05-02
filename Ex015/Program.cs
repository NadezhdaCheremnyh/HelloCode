// Lesson 4 Task 1 Напишите программу, которая принимает на вход число A
// и выдает сумму чисел от 1 до A

int SummaNumbers(int x)
{
    int summa = 0;
    for (int i = 1; i <= x; i++)
    {
        summa = summa + i;

    }
    return summa;
}
int count = 1;
int n = 5;
int value = 0;
while (count < n)
{
    Console.Write("Введите целое число: ");
    value = int.Parse(Console.ReadLine());
    if (value > 0)
    {
        Console.Write("Сумма чисел от 1 до " + value + " => ");
        Console.WriteLine(SummaNumbers(value));
        count++;
    }
    else Console.WriteLine("Введенное значение не является целым");
}
