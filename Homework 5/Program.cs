//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
Console.Clear();
Console.WriteLine("Enter massive length");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayW = new int[size];
int count = 0;
for (int i = 0; i < arrayW.Length; i++)
{
    arrayW[i] = new Random().Next(100, 1000);
    if(arrayW[i] % 2 == 0) count++;
    Console.Write(arrayW[i] + " ");
}  
Console.WriteLine();
Console.WriteLine ("Count of even numbers of this array is " + count);
*/
//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
void SumOfUnevenPosition(int size)
{
    int[]array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "  " ); 
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    sum = sum + array[i]; 
    Console.WriteLine();
    Console.WriteLine("The sum of numbers on uneven positions " + sum); 
}
Console.WriteLine("Enter massive length");
int size = Convert.ToInt32(Console.ReadLine());
SumOfUnevenPosition(size);
