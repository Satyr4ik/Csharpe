// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72

int number = new Random().Next(100, 1000);

int num1 = number / 100;
int num2 = number % 10;
int newNumber = 10*num1+num2;

Console.WriteLine(number);
Console.WriteLine(newNumber);

