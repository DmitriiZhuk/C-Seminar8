/*
Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// 1 Объект - случайные числа.
Random rnd = new Random();

// 2 Объявляю двумерный массив размером m×n
// можно так же получать длины строк и столбцов через Console.ReadLine() и Convert.ToInt32
int nRow = 4;

int[,] numArray = new int[nRow, nRow];

// 3 Заполняю массив, вывожу на экран.		
for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        numArray[i, j] = rnd.Next(1, 10);
        Console.Write(numArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 3 Сумма первой строки массива для последующего поиска минимума.
int min = 0;

for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        min = min + numArray[i, j];
    }
}

// 4 поиск и выведение минимальной строки			
int sumRow = 0;
int rowMinNum = 0;

for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        sumRow = sumRow + numArray[i, j];
    }

    Console.WriteLine("Сумма " + (i + 1) + " строки массива = " + sumRow);

    if (min > sumRow)
    {
        min = sumRow;
        rowMinNum = i;
    }

    sumRow = 0;

}
Console.WriteLine("Минимальное значение = " + min + " находится в строке " + (rowMinNum + 1));