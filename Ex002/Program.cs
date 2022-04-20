// Задача 1 Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
int count = 1;
int n = 4;
while (count < n)
{
    Console.Write("Введите первое число: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int B = int.Parse(Console.ReadLine());
    if (A > B)
    {
        Console.Write("max=");
        Console.WriteLine(A);
        Console.Write("min=");
        Console.WriteLine(B);
    }
    else
    {
        Console.Write("max=");
        Console.WriteLine(B);
        Console.Write("min=");
        Console.WriteLine(A);
    }
    count = count + 1;
}