// Lesson 6 Task 3 Показать треугольник Паскаля 
// Сделать вывод в виде равнобедренного треугольника

void PrintEmpty(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(" ");
    }
}

void TrianglePascal(int countStrings)
{
    int[,] c = new int[countStrings + 1, countStrings + 1];
    c[0, 0] = 1;
    PrintEmpty(countStrings + 1);
    Console.WriteLine("   " + c[0, 0]);
    int J = countStrings;
    for (int n = 1; n <= countStrings; n++)
    {
        PrintEmpty(J);
        for (int k = 0; k <= n - 1; k++)
        {
            if (k >= 1)
            {
                c[k, n] = c[k, n - 1] + c[k - 1, n - 1];
            }
            else
            {
                c[k, n] = 1;
            }
            if (c[k, n] < 10) Console.Write("   " + c[k, n]);
            else
            {
                if (c[k, n] >= 10 && c[k, n] < 100) Console.Write("  " + c[k, n]);
                if (c[k, n] >= 100) Console.Write(" " + c[k, n]);
            }
        }
        c[n, n] = 1;
        Console.WriteLine("   " + c[n, n]);
        J = J - 1;
    }
    //return c;
}

Console.Write("Введите целое положительное число: ");
int value = int.Parse(Console.ReadLine());
if (value > 0) TrianglePascal(value);
else Console.WriteLine("Введено неверное число");

