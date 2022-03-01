/*
//1 задача
Console.Write("Введите первое целое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2 * value2;

if(kvadrat_value2 == value1)
{
   Console.WriteLine("Квадрат второго числа соответствует первому");
}
else
{
    Console.WriteLine("Искомых соответствий не выявлено");
}

//2 задача

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if(number == 2)
    {
        Console.WriteLine("Вторник");
    }
    if(number == 3)
    {
        Console.WriteLine("Среда");
    }
    if(number == 4)
    {
        Console.WriteLine("Четверг");
    }
    if(number == 5)
    {
        Console.WriteLine("Пятница");
    }
    if(number == 6)
    {
        Console.WriteLine("Суббота");
    }
    if(number == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}
*/

//3 задача

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n*(-1);

while(neg_n <= n)
{
    Console.Write(neg_n + " ");
    neg_n+=3;
}
