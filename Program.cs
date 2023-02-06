// задача 19

Console.WriteLine("Введите пятизначное число: ");
int n= int.Parse(Console.ReadLine()!);
int a= n/10000;
int b= n/1000 % 10;
int c= n/10 % 10;
int d= n % 10;

if (a==d && b==c)
{
    Console.WriteLine($"Введеное пятизначное число {n} является палиндромом");
}
else
{
    Console.WriteLine($"Введеное число не палиндром");
}