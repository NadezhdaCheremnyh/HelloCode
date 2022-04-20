// Задача 3 Напишите программу, которая принимает на вход число и выдает, является ли число четным 
// (делится ли оно на два без остатка)
int count = 1;
int n = 4;
while (count < n)
{
    Console.Write("Введите число: ");
    int A = int.Parse(Console.ReadLine());
    int Ostatok = (A % 2);

    if (Ostatok == 0) Console.WriteLine("да");
    else Console.WriteLine("нет");

    count = count + 1;
}
