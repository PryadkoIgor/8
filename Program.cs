// Задача 62. Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


/*using System;
class GFG
{
    static readonly int R = 3;

    static readonly int C = 6;
    static void formSpiralMatrix(int[] arr, int[,] mat)
    {
        int top = 0,
            bottom = R - 1,
            left = 0,
            right = C - 1;
        int index = 0;

        while (true)
        {
            if (left > right)
            break;

            for (int i = left; i <= right; i++)
            mat[top, i] = arr[index++];
            top++;

            if (top > bottom)
            break;

            for (int i = top; i <= bottom; i++)

            mat[i, right] = arr[index++];
            right--;

            if (left > right)
            break;

            for (int i = right; i >= left; i--)

            mat[bottom, i] = arr[index++];
            bottom--;

            if (top > bottom)
            break;

            for (int i = bottom; i >= top; i--)

            mat[i, left] = arr[index++];
            left++;

        }

    }
static void printSpiralMatrix(int[,] mat)
{
    for (int i = 0; i < R; i++)
    {
        for (int j = 0; j < C; j++)
        Console.Write(mat[i, j] + " ");
        Console.WriteLine();
    }

}
public static void Main(String[] args)
{
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
    int[,] mat = new int[R, C];
    formSpiralMatrix(arr, mat);
    printSpiralMatrix(mat);
}
}*/



//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  1 2 4 7
//  2 3 5 9
//  2 4 4 8


/*Console.WriteLine($"Введите размер массива m x n и диапозое случайных чисел:");
int m = InputNumbers("Введите значения m: ");
int n = InputNumbers("Введите значения n: ");
int range = InputNumbers("Введите диапозон: от 1 до ");

int[,] inArray = new int[m, n];
CreatArray(inArray);
WriteArray(inArray);

Console.WriteLine($"Отсортированный массив: ");
WriteArray(inArray);
OrderArrayLines(inArray);

void OrderArrayLines(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1 - i; j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - j - 1; k++)
            {
                if (inArray[i, j] > inArray[i, j + 1])
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, j + 1];
                    inArray[i, j + 1] = temp;
                }
            }
        }
    }
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void CreatArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(range);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
return 0;*/


//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет нахолить строку с наименьшей суммой элементов.
// Например: 
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
//  Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

using System;
using System.Text;
using System.Linq;

const int n = 5;
const int m = 5;
const int max = 10;
var rand = new Random();
var array = new int [n][];

for (int i = 0; i < n; i++)
{
    array[i] = new int [m];
    for (int j = 0; j < m; j++)
        array [i][j] = rand.Next(max + 1);
}

Console.WriteLine("Массив = ");
foreach (var row in array)
{
    foreach (var value in row)
        Console.Write($"{value,4}");
    Console.WriteLine();
}
var min = array.Min(row => row.Max());
Console.WriteLine($"Наименьшая сумма в строке = {min}");



