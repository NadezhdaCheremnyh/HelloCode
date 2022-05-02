// Lesson 4 Task 3 Выяснить, являются ли три натуральных числа 
// сторонами прямоугольного треугольника

string ToFindTriangle(int[] array)
{
    string result = string.Empty;

    if (array[0] * array[0] == array[1] * array[1] + array[2] * array[2] ||
        array[1] * array[1] == array[0] * array[0] + array[2] * array[2] ||
        array[2] * array[2] == array[0] * array[0] + array[1] * array[1])

        result = "да ";
    else result = "нет";
    return result;
}
int count = 1;
int n = 3;

while (count < n)
{

    if (count == 1)
    {
        int[] number1 = { 2, 3, 4 };
        Console.Write(count + "  Даны три числа, являются ли они сторонами прямоугольного треугольника? { "
                      + number1[0] + ", " + number1[1] + ", " + number1[2] + " } -> ");
        Console.WriteLine(ToFindTriangle(number1));
    }

    if (count == 2)
    {
        int[] number2 = { 3, 4, 5 };
        Console.Write(count + "  Даны три числа, являются ли они сторонами прямоугольного треугольника? { "
                      + number2[0] + ", " + number2[1] + ", " + number2[2] + " } -> ");
        Console.WriteLine(ToFindTriangle(number2));
    }
    count++;
}
