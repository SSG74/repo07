// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FindColAverege(int[,] matrix, int rows, int columns)
{
    for (int i=0; i < columns; i++)
    {
        double sum = 0;
        for (int j=0; j < rows; j++)
        {
            sum = sum + matrix[j,i];
        }
        double average = sum / rows;
        Console.Write($"{average}. ");
    }
}

//  Выводим на печать массив
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
int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end+1);
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
int[,] matrix = FillArray(rows, columns, -100, 100);
//  Выводим массив на экран
PrintArray(matrix);
// Находим среднеарифметическое столбцов
FindColAverege(matrix, rows, columns);