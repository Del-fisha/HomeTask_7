// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

void Text(string text)
{
    Console.WriteLine($"{text} ");
}

int UserChoise()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

Text("Введите высоту массива: ");
int heigth = UserChoise();
Text("Введите ширину массива: ");
int width = UserChoise();
Text("Введите минимальное значение в массиве: ");
int min = UserChoise();
Text("Введите максимальное значение в массиве: ");
int max = UserChoise();
Console.Clear();
// int[,] array = FillArray(heigth, width, min, max);
// Text("Среднее арифметическое каждого столбца: ");
// double array1 = ArithmeticMean(array);
// PrintArray2(array1);

Random random = new Random();
int[,] arr = new int[heigth, width];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(min, max);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каджого столбца: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{Math.Round(sum / arr.GetLength(0), 1)} ");
}