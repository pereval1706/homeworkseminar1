﻿/*
//Задача 1
// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int ArythmSum(int A)
{
    int result = 0;

    int i = 1;
    while (i <= A)
    {
        result = result + i;

        i++;
    }

    return result;
}
Console.WriteLine("Введите ваше целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1)
{
    Console.WriteLine("Вы ввели ненатуральное число");
}
else
{
    Console.WriteLine($"Сумма чисел от 1 до {numA} равна {ArythmSum(numA)}");
}

// Задача 2
// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int Factorial(int N)
{
    int result = 1;

    int i = 1;
    while (i <= N)
    {
        result = result * i;

        i++;
    }

    return result;
}
Console.WriteLine("Введите ваше целое число: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN < 1)
{
    Console.WriteLine("Вы ввели ненатуральное число");
}
else
{
    Console.WriteLine($"Произведение чисел от 1 до {numN} равна {Factorial(numN)}");
}

//Задача 3
// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

void Dlina(int N)
{
    int l = 1;
    while (Math.Abs(N / 10)  > 1)
    {
        N = N / 10;
        l++;
    }
    Console.WriteLine("Количество цифр в введенном числе " + l);
}
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Dlina(number);
*/

//Задача 4
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порчдке.

void bitArray()
{
    int[] a = new int[8];
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0, 2);
        Console.Write(a[i] + " ");
    }
}
bitArray();
