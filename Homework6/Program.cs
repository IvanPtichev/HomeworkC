/*
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
*/
// Задача1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int Amount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

Console.WriteLine("Enter the size of the array");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(number);
int result = Amount(myArray);

Console.WriteLine($"the number of elements greater than zero is {result}");
*/

// Задача1.2: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());

int i = 0;
int count = 0;

while(i < size)
{
    Console.Write("Input a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0) count++;
    i++;
}
Console.WriteLine($"the number of elements greater than zero is {count}");
*/

// Задача2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double X(int k1, int b1, int k2, int b2)
{
    double temp = b2 - b1;
    double temp2 = k1 - k2;
    double diff = temp / temp2;
    return diff;
}


Console.WriteLine("Unput a number 1");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Unput a number 2");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Unput a number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Unput a number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

double j = X(numA, numB, num1, num2);

double result1 = numA * j + numB;
double result2 = num1 * j + num2;

Console.WriteLine($"{result1} {result2}");
*/