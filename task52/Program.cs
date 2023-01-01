// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Массив будет заполняться рандомно целыми числами в периоде (1-10). Значения количества строк и столбцов задает пользователь
// Значение среднего арифметического будет записываться в отдельный одномерный массив длинной равной количеству столбцов заполняемой выше матрицы.

void FillArray(int[,] matrix)   // метод заполнения массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintArray(int[,] matrix) // метод вывода массива
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

double[] FindSrArifmetic(int[,] matrix, double[] arifmetic, int rows)   // метод для посчета среднего арифметического столбцов матрицы. Возвращает одномерный массив со значениями
{
    double sum = 0; // Вводим переменную для хранения суммы значения столбцов в строке
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        arifmetic[i] = Math.Round(sum / rows, 2);
        sum = 0;
    }
    return arifmetic;
}

void PrintSrArifmetic(double[] arifmetic)   // выводит одномерный массив со значениями среднего арифметического столбцов
{
    System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arifmetic.Length; i++)
    {
        System.Console.Write($"{arifmetic[i]} ");
    }

}

Console.Clear();
System.Console.WriteLine("Введите количество строк в матрице: ");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество строк в матрице: ");
int columns = int.Parse(Console.ReadLine());

double[] arifmetic = new double[columns];
int[,] matrix = new int[rows, columns];

FillArray(matrix);
System.Console.WriteLine("Полученный массив: ");
PrintArray(matrix);
System.Console.WriteLine();

arifmetic = FindSrArifmetic(matrix, arifmetic, rows);
PrintSrArifmetic(arifmetic);