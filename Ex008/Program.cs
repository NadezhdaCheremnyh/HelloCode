// Lesson 2 Task 2 Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа
// Вариант 1
// int count = 1;
// int n = 4;
// string text = "result:  ";
//while (count < n)
//{
//    Console.Write("Введите трехзначное число: ");
//    int N = int.Parse(Console.ReadLine());
//    // Console.WriteLine(N);
//    if (N > 99 && N < 1000)
//    {
//        string stroka = Convert.ToString(N);
//        // Console.WriteLine(stroka);
//        string result = stroka.Substring(1, 1);
//        Console.WriteLine(text + result);
//        count++;
//    }
//    else Console.WriteLine("Введенное число не трехзначное");
//
//}
// Вариант 2 с использованием метода
string GetNumber(int x)
{
    string stroka = Convert.ToString(x);
    string result = stroka.Substring(1, 1);
    return result;
}
int count = 1;
int n = 4;
while (count < n)
{
    Console.Write("Введите трехзначное число: ");
    int value = int.Parse(Console.ReadLine());
    // Console.WriteLine(value);
    if (value > 99 && value < 1000)
    {
        Console.WriteLine("result " + GetNumber(value));
        //Console.Write(GetNumber(value));
        count++;
    }
    else Console.WriteLine("Введенное число не трехзначное");

}