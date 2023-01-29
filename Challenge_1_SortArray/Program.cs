/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */


Console.WriteLine("Печатаю массив...");
int[,] inArray = GetArray(5, 6, 0, 10);
PrintArray(inArray);
int[,] sortArray = SotrArray(inArray);
Console.WriteLine("Ниже получили новый массив с сортировкой по строкам от большего к меньшему");
PrintSortArray(inArray);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
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
int[,] SotrArray(int[,] array) // новый массив сортировочный
{
    int[,] newresult = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++) // новая переменная, которая будет обходить по каждому столбцу вдоль строки
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1]; //пузырьковая сортировка
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return newresult;
}
void PrintSortArray(int[,] inArray) // Печать отсортированного массива
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
