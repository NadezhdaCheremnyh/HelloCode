// Задача 6 Напишите программу, которая на вход принимает трехзначное число, 
// а на выходе показывает последнюю цифру этого числа 

int count = 1;
int n = 4;
string text = "result:  ";
while (count < n)
{
    Console.Write("Введите трехзначное число: ");
    int N = int.Parse(Console.ReadLine());
    // Console.WriteLine(N);
    if (N > 99 && N < 1000)
    {
        string stroka = Convert.ToString(N);
        // Console.WriteLine(stroka);
        string result = stroka.Substring(2, 1);
        Console.WriteLine(text + result);
        count++;
    }
    else Console.WriteLine("Введенное число не трехзначное");

}
