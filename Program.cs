//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Enter the number of rows:");
// int numRows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the number of columns:");
// int numColumns = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [numRows, numColumns];

// Random random = new Random();

// for (int i =0; i<array.GetLength(0); i++)
// {
//     for (int j =0; j<array.GetLength(1); j++)
//     {
//     array[i, j] = (random.NextDouble() * 20) - 10; 
//     }
// }

// for (int i =0; i<array.GetLength(0); i++)
// {
//     for (int j =0; j<array.GetLength(1); j++)
//     {
//     Console.Write ($"{array [i,j]:F1}"); 
//     }
//     Console.WriteLine();
// }

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Enter the number of rows:");
// int numRows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the number of columns:");
// int numColumns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Give me a number");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [numRows, numColumns];

// Random random = new Random();

// for (int i =0; i<array.GetLength(0); i++)
// {
//     for (int j =0; j<array.GetLength(1); j++)
//     {
//     array[i, j] = random.Next(0,10); 
//     }
// }

// for (int i =0; i<array.GetLength(0); i++)
// {
//     for (int j =0; j<array.GetLength(1); j++)
//     {
//     Console.Write ($"{array [i,j]} "); 
//     }
//     Console.WriteLine();
// }

// bool numberFound = false;

// for (int i =0; i<array.GetLength(0); i++)
// {
//     for (int j =0; j<array.GetLength(1); j++)
//     {
//     if (array[i,j] == userNumber)
//     {
//         numberFound = true;
//     }
    
//     }
//     Console.WriteLine();
// }

// if (numberFound == true)
// {
//   Console.Write ($"that number is in the array --> {userNumber} ");  
// }
//  else
//  {
// Console.Write ($"no such number in the array --> {userNumber}");
// }

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Enter the number of rows:");
int numRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns:");
int numColumns = Convert.ToInt32(Console.ReadLine());


int [,] array = new int [numRows, numColumns];

Random random = new Random();

for (int i =0; i<array.GetLength(0); i++)
{
    for (int j =0; j<array.GetLength(1); j++)
    {
    array[i, j] = random.Next(0,10); 
    }
}

for (int i =0; i<array.GetLength(0); i++)
{
    for (int j =0; j<array.GetLength(1); j++)
    {
    Console.Write ($"{array [i,j]} "); 
    }
    Console.WriteLine();
    }

Console.WriteLine();

double meanOfEachColum = 0; //создаю переменную для среднего арифметическогокаждого столбца

Console.Write ($"arithmetic mean of each column: "); //выводимпервую часть вывода вне цикла,для красоты
for (int j=0; j<array.GetLength(1); j++) //
{
    meanOfEachColum = 0;
    
    for (int i=0; i<array.GetLength(0); i++)
    {
    meanOfEachColum += array [i,j];    
    }
    
    meanOfEachColum /= numRows; //делим на колличество строк тк оно и будет колличествомэлементов в столбце
    
Console.Write ($" {meanOfEachColum:F2} ");

}