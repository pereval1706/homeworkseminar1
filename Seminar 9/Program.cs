// Задача 1
// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
/*
string Peresechenie(double b1, double k1, double b2, double k2)
{
    double xPeres = (double)(b1-b2)/(k1-k2);
    double yPeres = k1* xPeres + b1;
    string result = " " + xPeres + ";" + yPeres;
    return result;
}
Console.WriteLine("Введите b1: ");
int bline1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int kline1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int bline2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int kline2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Peresechenie(bline1, kline1, bline2, kline2)}");
*/

// Задача 2
// Показать треугольник Паскаля. Сделать вывод в виде 
// равнобедренного треугольник
