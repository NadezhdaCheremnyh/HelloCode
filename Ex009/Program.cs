// Урок 2 Задача 3 Напишите программу, которая принимает на вход два числа и выводит,  
// является ли второе число кратным первому. Если второе число не кратно первому, то 
// программа выводит остаток от деления

int count = 1;
int n = 3;
while (count < n)
{
    Console.Write("Введите первое число: ");
    int N1 = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int N2 = int.Parse(Console.ReadLine());

    int Ostatok = (N1 % N2);

    if (Ostatok == 0) Console.WriteLine("Кратно");
    else Console.WriteLine("Не кратно, остаток " + Ostatok);

    count = count + 1;
}
