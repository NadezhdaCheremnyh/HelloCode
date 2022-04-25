// Lesson 2 Task 4 Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23

string GetText(int x)
{
    int A = 7;
    int B = 23;
    string sl = "";
    if ((x % A) == 0 && (x % B) == 0) sl = "да ";
    else sl = "нет";
    return sl;
}
int count = 1;
int n = 4;
while (count < n)
{
    Console.Write("Введите число: ");
    int value = int.Parse(Console.ReadLine());
    Console.WriteLine(GetText(value));

    count++;
}
