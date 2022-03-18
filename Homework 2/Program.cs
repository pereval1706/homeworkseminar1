
//Домашняя работа
/*
//Задача 1

int Yuiio(int num)
{
    int n1 = num/10;
    int n2 = n1 % 10;
    return n2;
}
Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Вторая цифра этого числа " + Yuiio(number));
*/

//Задача 2

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(num / 100 > 0)
{
    Console.WriteLine("Третья цифра этого числа " + num % 10 % 10);
}
else
{
   Console.WriteLine("Нет третьей цифры");
}
Console.WriteLine();
