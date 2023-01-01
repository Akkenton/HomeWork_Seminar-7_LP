// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] matrix)   // Заполняем массив. Массив определяется типом double для заполнения именно вещественными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 2); //Границы рандом выбраны мной произвольно(от -10 до 10), т.к. в условии он не указан. Также идет округление до 2 знаков после запятой
        }
    }
}

void PrintArray(double[,] matrix)   // Выводим массив в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns]; //Массив определяется типом double для заполнения именно ВЕЩЕСТВЕННЫМИ числами
FillArray(matrix);
System.Console.WriteLine("Полученный массив: ");
PrintArray(matrix);
