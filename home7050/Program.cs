// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindNumber(int[,] matrix, int rows, int columns)
{
    Console.Write("Введите номер строки: ");
    int k = int.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int m = int.Parse(Console.ReadLine());
    
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            int num=0;
            if (i == k & j == m)
            {
                num = num + matrix[i,j];
                Console.WriteLine($"{num}");
            }
        }
    } 
    
    if (k > rows || m > columns)
    {
        Console.WriteLine($"Такого элемента массива нет");
    }
}

void PrintArray(int[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Заполняем массив
int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}
// заводим и печатаем количество строк и столбцов
int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Запрос количества строк
int rows = EnterData("Введите количество строк: ");
// Запрос количества столбцов
int columns = EnterData("Введите количество столбцов: ");
// Создаем двухмерный массив и заполняем его случайными числами
int[,] matrix = FillArray(rows, columns);
//  Выводим массив на экран
PrintArray(matrix);
// Запрос номера строки
// Запрос номера стобца
FindNumber(matrix, rows, columns);