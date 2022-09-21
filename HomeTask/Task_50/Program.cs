// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

Console.Write("Введите высоту массива: ");
int heigthArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int widthArray = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[heigthArray, widthArray];
void FillArray(int[,] arr)
{
    for (int i = 0; i < heigthArray; i++)
    {
        for (int j = 0; j < widthArray; j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

FillArray(array);
Console.Write("Введите индекс строки: ");
int indexOfHeigth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int indexOfWidth = Convert.ToInt32(Console.ReadLine());
int num = 0;

if (indexOfHeigth > heigthArray-1 ||
    indexOfHeigth < 0 ||
    indexOfWidth > widthArray-1 ||
    indexOfWidth < 0 )
    Console.Write("Числа с таким индексом нет в массиве");
else
{
    for (int i = 0; i < heigthArray; i++)
    {
        for (int j = 0; j < widthArray; j++)
        {
            if (i == indexOfHeigth && j == indexOfWidth)
                num = array[i, j];       
        }
    }
    Console.Write($"Число с введённым индексом: {num}");
}
