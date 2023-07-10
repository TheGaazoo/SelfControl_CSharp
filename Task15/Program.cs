//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 7 || day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
        Console.WriteLine("Будний день, еще работать и работать");   
    else if (day == 6 || day == 7)
        Console.WriteLine("Ура, выходной!");
   
else
    Console.WriteLine("Это не день недели, смотри что вводишь!");