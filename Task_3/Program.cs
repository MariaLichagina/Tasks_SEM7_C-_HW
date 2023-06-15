// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

WriteLine("Введите количество строк массива:");
int a = int.Parse(ReadLine());

WriteLine("Введите количество столбцов массива:");
int b = int.Parse(ReadLine());
int [,] array = GetArray(a, b);

PrintArray(array);
MeanColumn(array);


int [,] GetArray (int m, int n)
{
int [,] array = new int [m, n];
Random random = new Random();
int minValue = 1;
int maxValue = 100;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(minValue, maxValue+1);  
    }
    
}
return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

void MeanColumn (int [,] array)
{

int m = array.GetLength(0);
int n = array.GetLength(1);

for (int column = 0; column < n; column++){
    double sum = 0;
    double mean = 0;
    for (int line = 0; line < m; line++) {
        sum += array[line, column];
    }
    mean = sum/m;
    WriteLine($"{mean} ");
}
}