﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNum(int numN)
{

    int count = Convert.ToString(numN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = numN - numN % 10;
        result = result + (numN - advance);
        numN = numN / 10;
    }
    return result;
}

int sumNum = SumNum(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNum);