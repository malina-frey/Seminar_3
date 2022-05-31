/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. 
*/

Console.WriteLine("Введите координаты точки X и Y ");
int numberX = Convert.ToInt32(Console.ReadLine());
int numberY = Convert.ToInt32(Console.ReadLine());
if (numberX < 0 && numberY > 0)
{
    Console.WriteLine("плоскость I");
}
else if (numberX > 0 && numberY > 0)
{
    Console.WriteLine("плоскость II");
}
else if (numberX > 0 && numberY < 0)
{
    Console.WriteLine("плоскость III");
}
else if (numberX<0 && numberY<0)
{
    Console.WriteLine("плоскость IV");
}
else
{
    Console.WriteLine("координаты точки X и Y лежат на пересечении плоскостей I, II, III, IV");
}