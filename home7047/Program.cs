// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//  Выводим на печать массив
void PrintArray(double[,] arr)
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
double[,] FillArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
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
double[,] matrix = FillArray(rows, columns);
//  Выводим массив на экран
PrintArray(matrix);
