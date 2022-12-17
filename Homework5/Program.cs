
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void ShowArray(double[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array [i] + " ");
        }
        Console.WriteLine();
}

// Задача1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int Amount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i] % 2 == 0) count = count + 1;
    }
    return count;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value >= 100: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value < 1000: ");
int max = Convert.ToInt32(Console.ReadLine());

if(min >= 100 && max < 1000)
{
    int[] myArray = CreateRandomArray(size, min, max);
    int result = Amount(myArray);
    ShowArray(myArray);
    Console.WriteLine($"The number of even numbers in the array {result}");
}
else Console.WriteLine("Invalid number entered");
*/
// Задача2:  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
/*
int Sum(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i]; 
    return sum;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = Sum(myArray);
Console.WriteLine($"Sum of odd positions = {result}");
*/
// Задача3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return array;
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i];
    }
    double diff = max - min;
    return diff;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomDoubleArray(size, min, max);
ShowArray(myArray);
double result = Difference(myArray);
Console.WriteLine($"the difference between the maximum and minimum values of the array is {result}");
*/





