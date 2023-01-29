/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */


Console.WriteLine("Печатаю массив...");
int[,] inArray = GetArray(3, 4, 0, 10);
PrintArray(inArray);
int sumRows = GetSumRows(inArray, 0); // найдем сумму 0 строки
int minSumRows = 0; // пусть сумма первой строки будет минимальна
for (int i = 1; i < inArray.GetLength(0); i++)
{
    int tempSumLine = GetSumRows(inArray, i);
    if (sumRows > tempSumLine)
    {
        sumRows = tempSumLine;
        minSumRows = i;
    }
}
Console.WriteLine($"Наименьшая сумма элекментов ({sumRows}) соответствует {minSumRows + 1} строчки");


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

int GetSumRows(int[,] inArray, int i) // метод который находит сумму строк
{
    int sumRows = inArray[i, 0];
    for (int j = 1; j < inArray.GetLength(1); j++)
    {
        sumRows += inArray[i, j];
    }
    return sumRows;
}
