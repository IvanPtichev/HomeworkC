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

int ThirdNum(int num);
     While(num > 1000);
     {
        int num = NullableComparer / 10;
     }
     if(num < 1000)
     {
        int ed = num % 100 % 10;
     } 
         

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int newNum = ThirdNum(num1);

if(num1 >=100 || num1 <= -100)
{
    Console.WriteLine($"Третья цифра {newNum}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}