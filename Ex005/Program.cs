// Задача 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N 

int count = 1;
int n = 3;
while (count < n)
{
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    int index = 0;
    int znach = 0;
    int countChet = (N / 2);

    while (index < countChet)
    {
        znach = znach + 2;
        Console.Write(znach);
        Console.Write(", ");
        index = index + 1;
    }
    if (index == 0) Console.Write("Четных чисел нет ");
    count = count + 1;
    Console.WriteLine();
}
