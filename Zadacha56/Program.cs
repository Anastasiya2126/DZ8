/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int rows = ReadInt("Введите количество строк массива: ");
int columns = ReadInt("Введите количество столбцов массива: ");



int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

int[] sum = new int[numbers.GetLength(0)];
int indexSum = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
   for (int j = 0; j < numbers.GetLength(1); j++)
   {
        sum [indexSum] += numbers [i, j];
   }
   indexSum++;
}
WriteArray(sum);







Console.WriteLine($"Номер строки с наименьшей суммой элементов: {sumMax} строка.");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(int[,] array, int min = 1, int max = 10)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max +1);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
