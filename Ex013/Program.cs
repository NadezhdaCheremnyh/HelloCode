// Lesson 3 Task 2 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве

double Vector3D(int[] arrayA, int[] arrayB)
{
    double result = 0;
    int length = 3;
    int summa = 0;
    int x = 0;

    for (int i = 0; i < length; i++)
    {
        x = (arrayB[i] - arrayA[i]);
        //Console.WriteLine(x);
        summa = summa + x * x;
        //Console.WriteLine(summa);
    }
    result = Math.Round(Math.Sqrt(summa), 2);
    return result;
}
int count = 1;
int n = 3;
double value = 0;
while (count < n)
{
  
  if (count == 1)
   {
    int[] array1 = { 3, 6, 8 };
    int[] array2 = { 2, 1, -7 };
    Console.WriteLine(count + "  A={ " + array1[0] + ", " + array1[1] + ", " + array1[2] + " }");
    Console.WriteLine("   B={ " + array2[0] + ", " + array2[1] + ", " + array2[2] + " }");
    value = Vector3D(array1, array2);
   }
  
  if (count == 2)
   {
    int[] array3 = { 7, -5, 0 };
    int[] array4 = { 1, -1, 9 };
    Console.WriteLine(count + "  A={ " + array3[0] + ", " + array3[1] + ", " + array3[2] + " }");
    Console.WriteLine("   B={ " + array4[0] + ", " + array4[1] + ", " + array4[2] + " }");
    value = Vector3D(array3, array4);
   }

Console.Write("   Расстояние между А и В равно ");
Console.WriteLine(value);
count++;
}
