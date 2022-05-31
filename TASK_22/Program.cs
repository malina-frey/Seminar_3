/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void squareNumber(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = (i + 1) * (i + 1);
    }
}

void PrintSquareNumber(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i]);
        if(i<array2.Length-1)
        {
        Console.Write(", ");
        }
    }
}


int[] array = new int [number];

squareNumber(array);
Console.Write(number + " -> ");
PrintSquareNumber(array);