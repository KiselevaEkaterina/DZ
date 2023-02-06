// Задача 23

Console.Write($"Введите число: ");
int n=int.Parse(Console.ReadLine()!);
int count=1;
while (count<=n)
{
    Console.WriteLine($"{Math.Pow(count,3)}");

    if (count<1) Console.Write (", ");
    count++; 
}
