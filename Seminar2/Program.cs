/*
// Задача1
int FinfMaxNum(int num)
{
   int n1 = num % 10;
   int n2 = num / 10;

   if(n1 > n2)
   {
       return n1;
   }
   else
   {
       return n2;
   }
}
int number = new Random().Next(10, 99);
Console.WriteLine("Current number is " + number + " max part is " + FinfMaxNum(number));

//Задача 2
int Max(int num)
{
    int n1 = (num/100)*10;
    int n2 = num % 10;
    return n1 + n2;
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number + " ==> " + Max(number));

// Задача 3
void Chastnoe(int num1, int num2)
{
   if(num1 % num2 == 0)
   {
      Console.WriteLine("Yes!");
   }
   else
   {
       Console.WriteLine(num1 % num2);
   }
}
Console.WriteLine("Enter first number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

Chastnoe(number1, number2);

*/

void Proverka (int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Число " + num1 + " является кратным числам " + num2 + " и " + num3);
    }
    else{
        Console.WriteLine("Число " + num1 + " не является кратным числам " + num2 + " и " + num3);
    }
}

Console.WriteLine("Enter first number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number ");
int check1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number ");
int check2 = Convert.ToInt32(Console.ReadLine());

Proverka(number1, check1, check2);