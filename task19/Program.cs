// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

metka: Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Число не пятизначное");
    goto metka;
}

int result = ReverseInt5(num);
if (result == num) Console.WriteLine($"Это число -> {num} - палиндром");
else Console.WriteLine($"Это число -> {num} не палиндром");

int ReverseInt5(int number)
{
    return  number % 10 * 10000 + (number / 10 % 10) * 1000 + (number / 100 % 10) * 100 + (number / 1000 % 10) * 10 + (number / 10000);
}