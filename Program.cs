// Задача 1
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    double[,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(minValue, maxValue), 3);
    return array;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

 
 //Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
 /*
 int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "/t ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void NumberOfIndex(int[,] nums)
{
    Console.Write("Input a number of first index: ");
    int indexI = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of second indexs: ");
    int indexJ = Convert.ToInt32(Console.ReadLine());
    if (indexI >= nums.GetLength(0) || indexJ >= nums.GetLength(1))
        Console.WriteLine("There are no numbers with such indixes in the array!");
    else
    {
        int result = nums[indexI, indexJ];
        Console.WriteLine("Number " + result);
    }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
NumberOfIndex(myArray);
*/

 
 // Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[] AvarageColums(int[,] array)
{
    double[] nums = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double result = sum / array.GetLength(0);
        nums[j] = result;
    }
    return nums;
}
void ShowNewMyArray(double[] nums)
{
    Console.Write("Avarage array: [ ");
    for(int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.Write("]");
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] avarageArray = AvarageColums(myArray);
ShowNewMyArray(avarageArray);