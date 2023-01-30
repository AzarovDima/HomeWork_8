//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



int[,] matrix1 = GetMatrix(3, 3, 1, 10);
int[,] matrix2 = GetMatrix(5, 5, 1, 10);

Console.WriteLine("Дана пернвая матрица:");
PrintMatrix(matrix1);
Console.WriteLine();Console.WriteLine("Дана вторая матрица:");
PrintMatrix(matrix2);


int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] newMatrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            var rnd = new Random();
            newMatrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return newMatrix;
}
void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Console.Write($"{inMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}