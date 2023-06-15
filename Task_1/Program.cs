// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;

WriteLine("Введите количество строк массива:");
int m = int.Parse(ReadLine());

WriteLine("Введите количество столбцов массива:");
int n = int.Parse(ReadLine());

double [,] array = GetArray(m, n);
PrintArray(array);

double [,] GetArray (int m, int n)
{
double [,] array = new double [m, n];
Random random = new Random();
double minValue = -100;
double maxValue = 100;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
        
    }
    
}
return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]:f1} ");
        }
        WriteLine();
    }
}

