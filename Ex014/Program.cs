// Lesson 3 Task 3 Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N

void PrintCube(int x)
{
    int cube = 0;
    for (int i = 1; i <= x; i++)
    {
        cube = (i * i * i);
        Console.Write(cube + ", ");
    }
    Console.WriteLine();
}
int count = 1;
int n = 3;
int value = 0;
while (count < n)
{
    Console.Write("Введите целое число: ");
    value = int.Parse(Console.ReadLine());
    if (value > 0)
    {
        Console.Write("Таблица кубов числа: " + value + "  -> ");
        PrintCube(value);
        count++;
    }
    else Console.WriteLine("Введенное значение не от 1 до N");
}
