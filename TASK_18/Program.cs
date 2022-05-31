/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/


Console.WriteLine("Введите номер четверти ");
int number = Convert.ToInt32(Console.ReadLine());

void FindNumberQuater()
{

    if (number == 1)
    {
        Console.WriteLine("четверть находится в диапазоне координат (X<0;Y>0)");
    }
    else if (number == 2)
    {
        Console.WriteLine("четверть находится в диапазоне координат (X>0;Y>0)");
    }
    else if (number == 3)
    {
        Console.WriteLine("четверть находится в диапазоне координат (X>0; Y<0)");
    }
    else if (number == 4)
    {
        Console.WriteLine("четверть находится в диапазоне координат (X<0;Y<0)");
    }
    else
    {
        Console.WriteLine("четверть имеет четыре плоскости, введите число от 1 до 4");
    }
}

FindNumberQuater();