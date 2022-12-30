// Задача1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumber(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNumber(num - 1);
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowNumber(number);
*/

// Задача2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int Sum(int numA, int numB)
{
    if(numA <= numB) return Sum(numA + 1, numB) + numA; 
    else return 0;
}

Console.Write("Input a number 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA < numberB) Console.WriteLine($"the sum of the numbers in the segment is equal to {Sum(numberA, numberB)}");
else if( numberA > numberB) Console.WriteLine($"the sum of the numbers in the segment is equal to {Sum(numberB, numberA)}");
else if( numberA == numberB) Console.WriteLine("no numbers to find sum");
*/
// Задача3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Accerrman(int numA, int numB)
{
    if(numA == 0) return numB + 1;
    if( numB == 0) return Accerrman(numA - 1, 1);
    else return Accerrman(numA - 1, Accerrman(numA, numB - 1));
}

Console.Write("Input a number 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number 2: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"the Ackermann function of the numbers {m} and {n} is {Accerrman(m,n)}");