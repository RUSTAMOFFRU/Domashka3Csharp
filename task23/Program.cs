// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
CubeTable(number);

void CubeTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        double cube = Math.Pow(i, 3);
        Console.WriteLine($"{i,3} {cube,7}");
    }
}