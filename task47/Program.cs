// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



double[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double [rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1) / 10.0;
        }
    }
    return newArray;
}

void Show2DArray(double[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }  
}

Console.Write("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DRandomArray ( m , n , min , max);
Show2DArray(myArray);
