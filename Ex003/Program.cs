// Задача 2 Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чмсел
int count = 1;
int n = 4;
while (count < n)
{
    Console.Write("Введите первое число: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int B = int.Parse(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int C = int.Parse(Console.ReadLine());
    int max = A;

    if (B > max) max = B;
    if (C > max) max = C;

    Console.Write("max=");
    Console.WriteLine(max);
    count = count + 1;
}
