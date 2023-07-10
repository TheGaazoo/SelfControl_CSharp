//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (n >= 100 && n < 1000)
{
    number = (n % 100 - n % 10) / 10;
    Console.WriteLine($"Вторая цифра числа {n} = {number}");
}
else
Console.WriteLine("Это число не трехзначное!");