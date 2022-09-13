// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool SearchNum(int[] array, int num)
{
    bool exile =default;
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
        {
            exile = true;
            break;
        }
    }
    return exile;
}

int num = 4;
int[] arr = CreateArrayRndInt(8, -4, 4);
PrintArray(arr);
bool result = SearchNum(arr, num);
 
Console.WriteLine(result ? $" Число {num} присутствует в данном массиве." : $" Число {num} не присутствует в данном массиве.");
