// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



    int[,] array = Create2DArray(3,4);
    Print2DArray(array);
    double[] newArray = FindAverageEachLine(array);
    Console.WriteLine();
    Console.Write("Среднее арифмитическое каждого столбца: ");
    Print1StArray(newArray);


void Print1StArray(double[] newArray)
{
    
    for (var i = 0; i < newArray.Length; i++)
    {
        Console.Write(Math.Round(newArray[i], 1)  + " ");
    }
}   

void Print2DArray(int[,] array)
{
    
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] FindAverageEachLine (int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];

    for (var j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (var i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array [i,j];
        }
        newArray[j] = sum / array.GetLength(0);
    }
    return newArray;
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
}

