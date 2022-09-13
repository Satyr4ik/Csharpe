// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int ost = num1 % num2;

// if (num1 > num2)
// {
//     if (ost != 0 )
//     {
//         Console.WriteLine($"Остаток от деления равен: {ost}");
//     }
//     else Console.WriteLine("Второе число кратно первому");
// }
// else Console.WriteLine("Первое число меьше Второго числа, введите коректные данные.");


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string checkNumbers(int nummber1, int number2)
{
    int ost = nummber1 % number2;
    return ost == 0 ? "кратно" : $"не кратно, остаток {ost}";
}

Console.WriteLine(checkNumbers(num1, num2));
