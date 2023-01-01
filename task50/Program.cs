// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// !!! ВНИМАНИЕ. ОШИБКА В УСЛОВИИ - перепутаны входящие данные!!!!
// По договоренности на семинаре с Мансуром Шафигуллиным, на вход приходит значения элемента массива, а выводится либо его индексы, либо что элемента нет в массиве

// При решении задачи будет заполняться массив рандомно целыми числами в периоде (1,10). Количество столбцов, строк и искомое значение вводит пользователь. 
// Также будем искать ТОЛЬКО первое совпадение

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

void FindNumber(int[,] matrix, int number)   // Метод поиска числа в массиве
{
    bool flag = false; // вводим идентификатор-флаг для прерывания циклов, когда число найдено 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                System.Console.WriteLine($"Искомое число {number} находится на позиции ({i},{j}) в массиве");
                flag = true;
                break; // прерываем внутренний цикл, поскольку значение уже найдено
            }
            if (flag == true) break; // прерываем внешний цикл, поскольку значение уже найдено
        }
    }
    if (flag == false) System.Console.WriteLine("Такого значения нет в массиве!");
}
Console.Clear();

System.Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, columns];

FillArray(matrix);
System.Console.WriteLine("Заполенный массив: ");
PrintArray(matrix);
System.Console.WriteLine("Результат поиска: ");
FindNumber(matrix, number);
