﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int Change(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <=99) count ++;
    }
    return count;
}
void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
// int n = 0;
//     Console.Write("Введите минимальное число: ");
//     while (!int.TryParse(Console.ReadLine(), out n))
//     {
//         Console.Write("Ошибка ввода, введите число: ");
//     }
// int n = 0;
//     Console.Write("Введите максимальное число: ");
//     while (!int.TryParse(Console.ReadLine(), out n))
//     {
//         Console.Write("Ошибка ввода, введите число: ");
//     }

int[] arr = CreateArrayRndInt(5, 0, 999);
PrintArray(arr);
int result = Change(arr);
Console.WriteLine($"Количество совпадений: {result} ");


