// Задача 62: Заполните спирально массив 4 на 4.
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7


int[,] array = GetArray(4, 4);
int[,] vortexArray = GetNewArray(array);
PrintArray(vortexArray);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = 0;
        }
    }
    return result;
}
int[,] GetNewArray(int[,] inArray)
{
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= inArray.GetLength(0) * inArray.GetLength(1))
    {
        inArray[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < inArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= inArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > inArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return inArray;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}