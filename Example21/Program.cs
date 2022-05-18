// Lesson 6 Task 1 Составить частотный словарь элементов двумерного массива 
// 

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void CountNumbers(int[] array)
{
    int len = array.Length;
    int index = 0;
    int r = 0;
    string[,] arrNumbers = new string[len, 3];
    int Counts = 0;
    arrNumbers[0, 0] = Convert.ToString(array[0]);
    double percentage = 0.00;
    for (int i = 0; i < len; i++)
    {
        for (int k = 0; (!(Convert.ToString(array[i]) == arrNumbers[k, 0]) && (k <= index)); k++)
        {
            r = k;
        }
        if (r == index)
        {
            arrNumbers[index, 0] = Convert.ToString(array[i]);
            Counts = 1;
            for (int j = i + 1; j < len; j++)
            {
                if (array[j] == array[i]) Counts = Counts + 1;
            }

            arrNumbers[index, 1] = Convert.ToString(Counts);
            double c = Counts;
            double l = len;
            percentage = (c * 100) / l;
            arrNumbers[index, 2] = Convert.ToString(percentage);
            Console.WriteLine(arrNumbers[index, 0] + " встречается " + arrNumbers[index, 1] + " раз, частота " +
                              arrNumbers[index, 2] + " %");
            index = index + 1;
        }
    }
}
int[] Arr = { 1, 9, 9, 0, 2, 8, 0, 9 };
PrintArray(Arr);
CountNumbers(Arr);
