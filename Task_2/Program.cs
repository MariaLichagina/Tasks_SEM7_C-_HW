// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;

WriteLine("Введите количество строк массива:");
int a = int.Parse(ReadLine());

WriteLine("Введите количество столбцов массива:");
int b = int.Parse(ReadLine());
int [,] array = GetArray(a, b);
PrintArray(array);

WriteLine("Введите номер элемента массива:");
int num = int.Parse(ReadLine());

FindElement(array, num);

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

void FindElement (int [,] array, int num)
{  
int m = array.GetLength(0);
int n = array.GetLength(1);
    if (num > m*n || num <=0){
         Write("Такого элемента в массиве нет!");
         return;
    }

    int result;
    if (num <= n) {
        result = array[0, num-1];
    } else {
        int line = num/n;
        if (num%n == 0) {
            line = line - 1; 
        }
        result = array[line, num-n*line-1];   
    }
    WriteLine($"{result}");   
}