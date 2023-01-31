//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// формула умножения двух матриц!!! Где матрица 1 имеет размер M х K, матрица 2 — K х N, и матрица 3 — M х N. 
int[,] matrix1 = GetMatrix(4, 5, 1, 10);
int[,] matrix2 = GetMatrix(7, 3, 1, 10);
int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; // размер новой матрицы после умножения 
MultiplyMatrix(matrix1, matrix2, resultMatrix);                            

Console.WriteLine("Дана пернвая матрица:");
PrintMatrix(matrix1);
Console.WriteLine("Дана вторая матрица:");
PrintMatrix(matrix2);
Console.WriteLine("Произведение двух матриц:");
PrintMatrix(resultMatrix);

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
void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}