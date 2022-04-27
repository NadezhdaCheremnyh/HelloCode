// Lesson 3 Task 1 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом (перевертышем)

string GetText(string s)
{
    string result = string.Empty;
    int length = s.Length;
    int index = 0;
    int j = length;
    for (int i = 0; (s[i] == s[j - 1] && (i < j - 1)); i++)
    {
        j = j - 1;
        index = i;
    }
    if (index == (length / 2) - 1) result = "да ";
    else result = "нет";
    return result;
}
int count = 1;
int n = 4;
while (count < n)
{
    Console.Write("Введите пятизначное число: ");
    int value = int.Parse(Console.ReadLine());
    if (value > 10000 && value < 100000)
    {
        string stroka = Convert.ToString(value);
        Console.Write(stroka + " -> ");
        Console.WriteLine(GetText(stroka));
        count++;
    }
    else Console.WriteLine("Введенное число не является пятизначным");
}
