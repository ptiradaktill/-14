﻿;/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void GetNumb (int number)
{
Console.Write ($"{number} ->");

    for (int i = 1; i <= number; i++)
{
double cube = Math.Pow(i,3);
Console.Write($"{cube}, ");
}
}

Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine());

GetNumb(numb);