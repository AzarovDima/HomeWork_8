//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.WriteLine($"Задайте размер массива в формате X*Y*Z: ");
int x = InputNumbersForArray3D("Введите X: ", "Ошибка ввода, попробуйте снова!!! ");
int y = InputNumbersForArray3D("Введите Y: ", "Ошибка ввода, попробуйте снова!!! ");
int z = InputNumbersForArray3D("Введите Z: ", "Ошибка ввода, попробуйте снова!!! ");
Console.WriteLine();

double[,,] arrayDrei = new double[x, y, z];
FillArray(arrayDrei);
PrintArray(arrayDrei);

int InputNumbersForArray3D(string userInput, string errorMsg)
{
    while (true)
    {
        Console.Write(userInput);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        else Console.WriteLine(errorMsg);
    }
}
void FillArray(double[,,] inArray) //   //Math.Round(minValue + rnd.NextDouble() * (maxValue - minValue), 1);
{
    double[] newArray = new double[inArray.GetLength(0) * inArray.GetLength(1) * inArray.GetLength(2)];
    for (int x = 0; x < inArray.GetLength(0); x++)
    {
        for (int y = 0; y < inArray.GetLength(1); y++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                //var rnd = new Random();
                inArray[x, y, z] = (Math.Round(10 + (new Random().NextDouble() * 90), 2));
            }
        }
    }
}
void PrintArray(double[,,] inArray3D)
{
    for (int i = 0; i < inArray3D.GetLength(0); i++)
    {
        for (int j = 0; j < inArray3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < inArray3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={inArray3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}