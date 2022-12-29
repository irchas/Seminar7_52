// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArrayMartix(rows, columns, 0, 10);
PrintArray(array);

int [,] GetArrayMartix(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < columns; j++)
{
    double [] middle = new double[columns];
    double [] sum = new double[columns];

    for (int i= 0; i < rows; i++)
    {
    sum[j]= sum[j]+ array[i, j];
    middle[j] = (sum[j])/(i+1);
    }
    Console.Write(string.Format("{0:f2}", middle[j])+" ");
}