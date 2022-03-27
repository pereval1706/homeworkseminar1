/*
// Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int length = num.Length;

bool FindPalind()
{
    for (int i = 0; i < length / 2; i++)
        while (num[i] == num[length - 1])
        {
            return true;
        }
    return false;
}

if(FindPalind())
{
    Console.Write("Введенное число " + "является палиндромом");
}
else
{
    Console.Write("Введенное число " + "не является палиндромом");
}


//Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    return Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2) + Math.Pow(zDistance,2));
}
double xA, yA, xB, yB, zA, zB;
double distance;

Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());
distance = GetDistance(xA, yA, zA, xB, yB, zB);

Console.WriteLine("Расстояние между точками " + distance);

*/

// Задача 3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int FindCube(int numA)
{
     int c = 1;
     while(c <= numA)
     {
         int d = c * c * c;
         Console.WriteLine(d);
         c = c + 1;
     }
     return 0;
}

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
FindCube(N);