﻿/*
// Задача 1
int GetQuart(double xPoint, double yPoint)
{
    if(xPoint > 0 && yPoint > 0) return 1;
    if(xPoint < 0 && yPoint > 0) return 2;
    if(xPoint < 0 && yPoint < 0) return 3;
    if(xPoint > 0 && yPoint < 0) return 4;
    return 0;
}


double x, y;
int quartNum;
Console.Write("Input X: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y: ");
y = Convert.ToDouble(Console.ReadLine());

quartNum = GetQuart(x, y);
if(quartNum == 0) Console.WriteLine("Нельзя однозначно определить четверть");
else Console.WriteLine("Данная точка находится в " +  quartNum + " четверти");


// Задача 2

void Getret(int numQuad)
{
    switch(numQuad)
    {
        case 1:
        {
             Console.WriteLine("В данной четверти координаты могут быть с след диапозоне: X > 0, Y > 0");
            break;
        }
        case 2:
        {
            Console.WriteLine("В данной четверти координаты могут быть с след диапозоне: X < 0, Y > 0");
            break;
        }
        case 3:
        {
            Console.WriteLine("В данной четверти координаты могут быть с след диапозоне: X < 0, Y < 0");
            break;
        }
        case 4:
        {
            Console.WriteLine("В данной четверти координаты могут быть с след диапозоне: X > 0, Y < 0");
            break;
        }
        default:
        {
            Console.WriteLine("Такой четверти не существует");
            break;
        }   
    }
    
}

int numGet;
Console.Write("Введите номер четверти (целое число от 1 до 4): ");
numGet = Convert.ToInt32(Console.ReadLine());
Getret(numGet);
*/

// Задача 3

double GetDistance(double x1, double y1, double x2, double y2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;

    return Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2));
}
double xA, yA, xB, yB;
double distance;

Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
distance = GetDistance(xA, yA, xB , yB);
Console.WriteLine("Расстояние между точками " + distance);
