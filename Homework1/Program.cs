// Задача1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

/*
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine("Наибольшее число "+ numberA);
}
else
{
    Console.WriteLine("Наибольшее число "+ numberB);
}
*/

// Задача2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

/*

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второe число");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;

if(numA > numB)
{
    if(numA > numC)
    {
        Console.WriteLine("Максимальное число " + max);
    }
    else
    {
        max = numC;
        Console.WriteLine("Максимальное число " + max);

    }
}
else
{
    max = numB;
    if(max > numC)
    {
        Console.WriteLine("Максимальное число " + max);
    }
    else
    {
        max = numC;
        Console.WriteLine("Максимальное число " + max);
    }
}
*/

// Задача3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.WriteLine("Введите число, за исключением нуля");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else{
    Console.WriteLine("Число нечётное");
}
*/

// Задача4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите положительное число");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

if(num>0)
{while(current <= num)
    {
    Console.WriteLine(current + " ");
    current +=2;
    }
}
else
{
    Console.WriteLine("Вы ввели отрицательное число");
}
*/
