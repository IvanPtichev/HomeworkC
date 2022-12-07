// Задача1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("enter the number");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num = num * -1;

int coupNum = 0;
int temp = num;

while(temp > 0)
{
    coupNum = coupNum * 10 + temp % 10;
    temp = temp / 10;
}
if(num > 0)
{
    if(num == coupNum)
    {
    Console.WriteLine("palindrome");
    }
    else
    {
    Console.WriteLine("not a palindrome");
    }
}
*/
// Задача2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Hipotenuse(double xA,double xB,double yA,double yB,double zA,double zB)
{
    double lenght = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + Math.Pow(zB-zA, 2));
    return Math.Round(lenght, 2);
}

Console.WriteLine("imput an x-coordinate of point A");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an x-coordinate of point B");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an y-coordinate of point A");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an y-coordinate of point B");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an z-coordinate of point A");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an z-coordinate of point B");
double zB = Convert.ToDouble(Console.ReadLine());

double result = Hipotenuse(xA, xB, yA, yB, zA, zB);

Console.WriteLine($"distance {result}");
*/

// Задача3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int num)
{
    int counter = 1;
    while(counter <= num)
    {
        Console.Write(Math.Pow(counter, 3));
        if(counter != num) Console.Write(", ");
        else Console.Write(".");
        counter++;
    }
}

Console.WriteLine("imput an number");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number = number * -1;
Cube(number);