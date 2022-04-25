// Lesson 2 Task 8 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

string GetText(int x)
{
    string sl = "";
    if ((x == 6) || (x == 7)) sl = "да ";
    else sl = "нет";
    return sl;
}
int count = 1;
int n = 4;
while (count < n)
{
    Console.Write("Введите цифру: ");
    int value = int.Parse(Console.ReadLine());
    if (value > 0 && value < 8)
    {
        Console.WriteLine(GetText(value));
        count++;
    }
    else Console.WriteLine("Такого дня недели нет");
}
