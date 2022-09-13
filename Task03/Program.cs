/*
Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
Вариант создания функции:
Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
Пример:
Массив размером 3 x 3
10 11 55
33 41 23
17 28 34
*/

// 1 Объект - случайные числа.
Random rnd = new Random();

// 2 Объявляю двумерный массив размером m×n
Console.Write("Введите количество элементов первой строки 2d массива (максимальное - 7): ");
int nRow = Convert.ToInt32(Console.ReadLine());

int start = 10;
int stop = 99;
int check = 50;

if (nRow * nRow < check)
{

    int[,] numArray = new int[nRow, nRow];

    // 3 Заполняю массив с использованием ф-ции FindUniq, вывожу на экран.		
    for (int i = 0; i < numArray.GetLength(0); i++)
    {
        for (int j = 0; j < numArray.GetLength(1); j++)
        {
            int num;
            do
            {
                num = rnd.Next(start, stop);
            } while (FindUniq(numArray, num));

            numArray[i, j] = num;
            Console.Write(numArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine($"Число элементов = {nRow * nRow}. По условиям задачи число элементов массива должно быть меньше {check}");

}

// ZZ - Функция подбора уникального значения.		
static bool FindUniq(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (num == arr[i, j])
            {
                return true;
            }
        }
    }
    return false;
}