/*
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
*/
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


// Задача1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void Ordering(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int max = array[i,j];
            for(int k = j, count = 0; k < array.GetLength(1); k++, count++)
            {
                if(max < array[i,k])
                {  
                    max = array[i,k];
                    int temp = array[i,k - count];
                    array[i,k - count] = max;
                    array[i,k] = temp;
                }

           }

        }
    }

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Ordering(myArray);
Show2dArray(myArray);
*/
// Задача2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[] SumRowsArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
            newArray[i] = sum;
        }
    }
    return newArray;
}

void ShowMinIndex(int[] array)
{
    int min = array[0];
   
    for(int i = 0;i < array.Length; i++)
        if(min > array[i]) min = array[i];

    int j = 0;

    while(array[j] != min)
        j++;
    Console.WriteLine($"line number with minimum amount {j + 1}");
    
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

if(myArray.GetLength(0) > myArray.GetLength(1))
{
    int[] sumArray = SumRowsArray(myArray);

    ShowMinIndex(sumArray);
}
else Console.WriteLine("Invalid array");
*/

// Задача3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MultiplicationArray(int[,] arrayA, int[,] arrayB)
{
    int[,] newArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for(int i = 0; i < arrayA.GetLength(0); i++)
    {
        for(int j = 0; j < arrayB.GetLength(1); j++)
        {
            for(int k = 0; k < arrayA.GetLength(1); k++)
            {
                newArray[i,j] += arrayA[i,k]*arrayB[k,j];  
            }
        }   
    }
    return newArray;
}


int[,] oneArray = CreateRandom2dArray();
Show2dArray(oneArray);
int [,] twoArray = CreateRandom2dArray();
Show2dArray(twoArray);

if(oneArray.GetLength(1) == twoArray.GetLength(0))
{
    int[,] myArray = MultiplicationArray(oneArray, twoArray);
    Show2dArray(myArray);
}
else Console.WriteLine("It is not possible to find the result of multiplication");
*/
// Задача4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
/*
int[,,] Create3dArray(int rows, int columns, int height)
{
    int[,,] array = new int[rows, columns, height];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = 0;
                int num = new Random().Next(10, 100);
                while(array[i,j,k] == 0)
                {
                    if(!IsInArray(num, array)) array[i,j,k] = num;
                    else num = new Random().Next(10, 100);
                }
            }
    return array;

}

bool IsInArray(int num, int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                if(array[i,j,k] == num) return true;    
    return false;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i,j,k] + $"({i}, {j}, {k}) " );
}

Console.Write("Input a number of rows: ");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int numColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of height: ");
int numHeight = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3dArray(numRows, numColumns, numHeight);
Show3dArray(myArray);
*/

// Задача4: Напишите программу, которая заполнит спирально массив 4 на 4
/*
int[,] CreateSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int direction = 0;
    int ro = rows -1;
    int co = columns -1;
    int x = 0;
    int y = 0;

    while(ro > 0 && co > 0)
    {

        if( direction == 0)
        {
            int i = x;
            for(int j = y ; j < co + 1 ; j++)
            {
                Console.Write("Input a number: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
                y = j;
            }
            x++;
            direction = 1;
            ro -= 1;
            co+=1;
        }
        
        else if( direction == 1) 
        {
            int j = y;
            for(int i = x; i <= ro +1 ; i++)
            {
                Console.Write("Input a number: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
                x = i;
            }
            y--;
            direction = 2;
            co -= 1;
            ro +=1;
        }
        else if( direction == 2) 
        {
            int i = x;
            for(int j = y; j >= array.GetLength(1) - co - 1; j--)
            {
                Console.Write("Input a number: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
                y = j;
            }
            x--;
            direction = 3;
            ro -= 1;
        }
        else if( direction == 3)
        {
            int j = y;
            for(int i = x; i >= array.GetLength(0) - ro - 1; i--)
            {
                Console.Write("Input a number: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
                x = i;
            }
            y++;
            direction = 0;
            co -=1;
        }
        
    }
    return array;
}

Console.Write("Input a number of rows: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int numB = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiralArray(numA, numB);
Show2dArray(myArray);
*/