
int[,] CreateRandom2dArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateNewArray(int line, int column, int minValue, int maxValue)
{
    double[,] array = new double[line, column];
    for(int i = 0; i < line; i++)
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return array;
}

void ShowArray( double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)  
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateNewArray(rows, columns, min, max);
ShowArray(myArray);
*/

// Задача2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void IndexValue( int[,] array, int numA, int numB)
{
    if(numA < array.GetLength(0) && numB < array.GetLength(1))
    {
         int i = numA;
         int j = numB;
         Console.WriteLine($"array element at given index is equal to {array[i,j]}");
    }
    else
    {
       Console.WriteLine("There is no such index.");
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);


Console.Write("Input an index 1: ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an index 2: ");
int index2 = Convert.ToInt32(Console.ReadLine());

IndexValue(myArray, index1, index2);


// Задача3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
double[] Average(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
             sum += array[j,i]; 
             newArray[i] =Math.Round(sum / array.GetLength(0), 1);
        }
    }
    return newArray;
}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ": ");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] result = Average(myArray);
ShowDoubleArray(result);
*/