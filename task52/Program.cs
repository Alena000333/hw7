// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray ( int rows, int columns)
{
int[,] newArray = new int[rows,columns];
for(int i = 0; i < rows; i++)
{
for(int j = 0; j < columns; j++)
{
newArray[i,j] = new Random().Next(1,11);
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
Console.Write(array[i,j]+" ");
}
Console.WriteLine();
}
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n);
Show2DArray(myArray);


for (int j = 0; j < myArray.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        sum += myArray[i, j];
    }
    Console.WriteLine($" среднее арифметическое {j+1} столбца = { sum / myArray.GetLength(0)}");
}
