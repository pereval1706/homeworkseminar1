//Задача 1
//Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] arrayA = new int[12];
int summapos = 0;
int summaneg = 0;
for (int i = 0; i < 12; i++)
{
    arrayA[i] = new Random().Next(-9, 10);
    if (arrayA[i] > 0)
    {
        summapos = arrayA[i] + summapos;
    } 
    else summaneg = arrayA[i] + summaneg;

    Console.WriteLine(arrayA[i]);
}

Console.WriteLine($"positive is {summapos} negitive is {summaneg}");


//Задача 2
//Напишите программу замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.

int[] arrayA = new int[12];
for (int i = 0; i < 12; i++)
{
    arrayA[i] = new Random().Next(-9, 10);
    
    Console.Write(arrayA[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 12; i++)
{
    Console.Write(arrayA[i] * (-1) + " ");
}

//Задача3
//Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

Console.Clear();
int[] arrayW = new int[15];
int tumbler = 0;
for (int i = 0; i < 15; i++)
{
    arrayW[i] = new Random().Next(1, 20);
    Console.Write(arrayW + " ");
}
Console.WriteLine("Enter the number ");
int numA = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 15; i++)
{
    if (arrayW[i] == numA) 
    {
        Console.WriteLine("Yes");
        tumbler = 1;
        break;
    }
}
if (tumbler == 0) Console.WriteLine("No");

//Задача4
//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Console.Clear();
int[] arrayW = new int[123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    arrayW[i] = new Random().Next(1, 1000);
    if(arrayW[i] < 100 && arrayW[i] > 9) count++;
}
Console.WriteLine(count);
*/

//Задача5
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

Console.WriteLine("Enter massive length");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrayU = new int[num];
int dlina = 1;
if(num%2 == 0) dlina = 0;
int[] arraY = new int[(num/2) + dlina];
for (int i = 0; i < num; i++)
{
    arrayU[i] = i+1;
    Console.WriteLine(arrayU[i] + " ");
}
Console.WriteLine();
for (int i = 0; i <((num/2)+dlina); i++)
{
    arraY[i] = arrayU[i] * (arrayU[num-i-1]);
    if(i == num - i-1) arraY[i] = arrayU[i];

    Console.Write(arraY[i] + " ");
}











/*
// 1 задача
void RandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int prom =new Random().Next(-99, 100);
            if(prom/10 == 0) {array[i,j] = prom*10;}
            else {array[i, j] =prom;} 
            Console.Write(array[i, j] + "");
        }
    }
    Console.WriteLine("");
}

// 2 задача

void SumIndexArray(int m, int n)
{
    int[,] array = new int [m,n];
    for(int i=0; i<m, n++)
     {
         for(int j = 0; j < n; j++)
         {
             array[i,j] = await+j;
             Console.Write(array[i,j] + ""); 
         }
     }
     Console.WriteLine("";)


// 3 задача


void RandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            if (i % 2 == 0 && j % 2 == 0) { array[i, j] = array[i, j] * array[i, j]; }
            Console.Write(array[i, j] + "");
        }
    }
    Console.WriteLine("");
    
}
RandomArray(3, 4);

void SumDiagArray(int m)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            
            Console.Write(array[i, j] + "");
        }
    }
    Console.WriteLine("");
    

int sum = 0;
for(int i=0; i<m; i++)
{
    sum=sum + array[i,i];
}
Console.WriteLine("Сумма элементовб наход на гл диаг " + sum);
SumDiagArray(4);
*/
