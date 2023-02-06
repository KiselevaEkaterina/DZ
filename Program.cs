// программа которая на вход принимает 2 числа и на выходе показывает какое больше и меньше.

Console.Write("Ведите первое число: ");
int a=int.Parse(Console.ReadLine()!);

Console.Write("Ведите второе число: ");
int b=int.Parse(Console.ReadLine()!);

if (a>b)
{    
    Console.WriteLine($"Большее число {a}");
    Console.WriteLine($"Меньшее число {b}");
    
}
else
{
    Console.WriteLine($"Большее число {b}");
    Console.WriteLine($"Меньшее число {a}");
}
