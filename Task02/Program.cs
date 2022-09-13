/*
Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// 1 Объект - случайные числа.
Random rnd = new Random();

// 2 Объявляю двумерные квадратные массивы размером nRow×nRow
int nRowCol = 2;

int[,] numArrayOne = new int[nRowCol, nRowCol];
int[,] numArrayTwo = new int[nRowCol, nRowCol];
int[,] numArrayMultiply = new int[nRowCol, nRowCol];

// 3 Заполняю массивы через функцию заполнения массива.	
Console.Write("Первый массив:");
FillArray(numArrayOne);
ShowArray(numArrayOne);

Console.Write("Второй массив:");
FillArray(numArrayTwo);
ShowArray(numArrayTwo);


// 4 Перемножаю элементы массива 1 и 2 и записываю их в numArrayMultiply
for (int i = 0; i < numArrayOne.GetLength(0); i++)
{
    for (int j = 0; j < numArrayTwo.GetLength(1); j++)
    {
        for (int k = 0; k < numArrayTwo.GetLength(0); k++)
        {
            numArrayMultiply[i, j] += numArrayOne[i, k] * numArrayTwo[k, j];
        }
    }
}

// 5 Вывожу на экран итоговый массив numArrayMultiply:
Console.WriteLine("Перемноженный массив:");
ShowArray(numArrayMultiply);

// ZZ - Функция заполнения массива.
void FillArray(int[,] numArray)
{
    for (int i = 0; i < numArray.GetLength(0); i++)
    {
        for (int j = 0; j < numArray.GetLength(1); j++)
        {
            numArray[i, j] = rnd.Next(1, 10);
        }
    }
    Console.WriteLine();
}

// ZZ - Функция вывода массива на экран.
void ShowArray(int[,] numArray)
{
    for (int i = 0; i < numArray.GetLength(0); i++)
    {
        for (int j = 0; j < numArray.GetLength(1); j++)
        {
            Console.Write(numArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}