//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int NatStepen(int numA, int numB)
{
    int result;
    for (int i = 1; i <= numB; i ++) 
    {
        result = result * numA;
    }
    return result;
}
Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int result2 = NatStepen (A, B);
Console.Write(A + " в степени " + B + " равняется " + result2);

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumOfDigit(int numC)
{
    int result = numC%10;
    while(numC/10 > 0)
    {
        numC = numC/10;
        result = result + numC%10;
    }
    return result;
}
Console.Write("Введите целое число: ");
int C = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма цифр этого числа " + SumOfDigit(C));

*/

//Задача 3: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] Array8()
{
    int[] arrayd = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arrayd[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayd;
}

void ResultArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}

Console.Write("Введите 8 чисел ");
Console.WriteLine();
ResultArray(Array8(N));
