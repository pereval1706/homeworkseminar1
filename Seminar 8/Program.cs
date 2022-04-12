
// Задача 1
// Задайте двумерный массив. .напишите прогроамму, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine($"Введите колчество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите колчество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
for(int i=0; i<+1; i++)
{
    for(int j=0; j< array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(0,10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("\nИзмененный ");
void ChangeArray(int [,] argArray)
{
    int temp;
    {
        int i=0;
        for(int j=0; j< argArray.GetLength(0); j++)
        {
            temp = argArray[i,j];
            argArray[i,j]=argArray[argArray.GetLength(0)-1, j];
            argArray[argArray.GetLength(0)-1, j] = temp;
        }
    }
}
ChangeArray(array);
for(int i=0; i<+1; i++)
{
    for(int j=0; j< array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

// Задача 2
// Напишите программу, которая заменяет строки на столбцы. Всл,если это невозможно, программа должна вывксти сообщ для пользователя.
/*
int[,] MakeArray()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во стобцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (m!=n)
    {
        Console.WriteLine("Размеры строк и столбцов не равны и их нельзя поменять");
        Console.WriteLine("Введите количество строк: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во стобцов: ");
        int n = Convert.ToInt32(Console.ReadLine());
    }
    int[,] array = new int[m,n];
    for(int i=0; i< array.GetLength(0); i++)
    {
        for (j=0; j< array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,100);
            Console.WriteLine(array[i,j]);
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] argArray)
{
    
    int i=0;
    for (int j=0; j< argArray.GetLength(1))
    {

    }
}
int[,] quadrateArray = MakeArray();


// Задача 3
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
async void CrossDeleting(int[,] matr)
{
    int minI=0,
        minJ=0,
        min= matr[0,0];
    for (int i=0; i< matr.GetLength; i++)
    {
        for (int j=0; j< matr.GetLength; j++)
        if (matr[i,j]<min)
        {
            minI=i;
            minJ=j;
        }
    }
}
*/