// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5    7    -2  -0,2
//  1   -3,3    8  -9,9
//  8    7,8  -7,1   9
Console.Clear();

Console.WriteLine("Введите желаемую высоту массива: ");
int higthArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите желаемую ширину массива: ");
int widthArray = Convert.ToInt32(Console.ReadLine());
Console.Clear();

double[,] array = new double[higthArray, widthArray];

void doubleArray(double[,] arr)
{
    for (int i = 0; i < higthArray; i++)
    {
        for (int j = 0; j < widthArray; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 100)/10.0);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
doubleArray(array);

