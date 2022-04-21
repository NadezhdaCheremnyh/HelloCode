// Задача 5 Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N 

int count = 1;
int n = 3;
while (count < n)
{
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    int index = 0;
    int znach = 0;
    int countZnach = (N * 2 + 1);

    while (index < countZnach)
    {
        znach = ((-1) * N);
        N = N - 1;
        Console.Write(znach);
        Console.Write(", ");
        index = index + 1;
    }

    count = count + 1;
    Console.WriteLine();
}

