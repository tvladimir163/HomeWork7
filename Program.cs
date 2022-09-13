Console.Clear();


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Ввкдите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Ввкдите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("\n");

// double[,] arrey = new double[rows, columns];

// for (int i = 0; i < arrey.GetLength(0); i++)
// {
//     for (int j = 0; j < arrey.GetLength(1); j++)
//     {
        
//         arrey[i, j] = new Random().NextDouble() * 10;

//         Console.Write($" {arrey[i, j]:f2} ");
//     }
//     Console.WriteLine();
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("введите номер строчки: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("введите номер столбца: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int row = new Random().Next(5, 15);
// int column = new Random().Next(5, 15);

// int[,] matrix = new int[row, column];
// FillArray(matrix);
// PrintArray(matrix);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// if (rows < matrix.GetLength(0)-1 && columns < matrix.GetLength(1)-1)
// {
//     Console.WriteLine($"Значение {matrix[rows-1, columns-1]}");
// }
// else
// {
//     Console.WriteLine($"{rows},{columns} -> таких координат не существует");
// }




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int row = new Random().Next(2, 5);
// int colum = new Random().Next(2, 5);

// int[,] matrix = new int[row, colum];
// FillArray(matrix);
// PrintArray(matrix);


// double[] ArithmeticColumn = new double[matrix.GetLength(1)];

// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     double result = 0.0;
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         result += matrix[j, i];
//     }
//     ArithmeticColumn[i] = result / matrix.GetLength(0);
// }
// PrintArithmeticColumn(ArithmeticColumn);


// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "    ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PrintArithmeticColumn (double[] array)
// {
//     Console.WriteLine("среднеарифметическое столбцов:");
//     for (int i = 0; i < array.Length; i++)
//     {
     
//         Console.Write($"{array[i]:f2} ");
//     }
//     Console.WriteLine();
// }