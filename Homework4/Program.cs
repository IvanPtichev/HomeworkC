// Задача1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree(int num1, int num2)
{
    int result = num1;
    int current = 1;
    while(current < num2)
    {
        result = result * num1;
        current++;
    }
    return result;
}

Console.WriteLine("Unput a number 1");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Unput a number 2");
int numB = Convert.ToInt32(Console.ReadLine());

int result = Degree(numA, numB);

Console.WriteLine($"{numA} to the extent {numB} equals {result}");
*/
// Задача2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    int current = num;
    int sum = 0;

    while(current !=0)
    {
        sum = sum + num % 10;
        num = num/10;
        current = current/10;
    }
    return sum;
}
Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);

Console.WriteLine($"the sum of the digits in the number is {sum}");
*/
// Задача3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

