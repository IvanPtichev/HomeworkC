// Задача1  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/*
int SecondNum(int num)
{
    int ed = num % 100;

    int result = ed / 10;
    return result;
}

Console.WriteLine("Введите трёхзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int newNum = SecondNum(num1);

if(num1 >= 100 && num1 < 1000 || num1 <= - 100 && num1 > -1000)
{
    Console.WriteLine($"второе число {newNum}");
}
else
{
    Console.WriteLine("Введено неверное число");
}
*/

// Задача2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int ThirdNum(int num)
     { 
        int ed = num % 100 % 10;
        return ed;
     } 
         
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 > 100 || num1 < -100)
{
    while(num1 >= 1000 || num1 <= - 1000)
    {
    num1 = num1 / 10;
    }
    int newNum = ThirdNum(num1);
    Console.WriteLine($"Третья цифра {newNum}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/

// Задача3:Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Введите число от 1 до 7, где 1 - это понедельник, а 7 - воскресенье");
int day = Convert.ToInt32(Console.ReadLine());
if(day <=7)
{
    if(day <=5)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}
else
{
    Console.WriteLine("Введено неверное число");
}
*/