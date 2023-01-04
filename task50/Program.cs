//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет




int[,] Create2DRandomArray ( int rows, int columns)
{
    int[,] newArray = new int [rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(1, 101);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
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

int[,] myArray = Create2DRandomArray ( m , n );
Show2DArray(myArray);

Console.Write("Введите индекс строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца");
int columns = Convert.ToInt32(Console.ReadLine());


if (rows < myArray.GetLength(0) && columns < myArray.GetLength(1)) Console.WriteLine(myArray[rows, columns]);
else Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");