// Задача 21.

Console.WriteLine($"Введите X1: ");
int x1=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y1: ");
int y1=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Z1: ");
int z1=int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите X2: ");
int x2= int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y2: ");
int y2=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Z2: ");
int z2=int.Parse(Console.ReadLine()!);

double x3= Math.Pow(x2-x1,2);
double y3= Math.Pow(y2-y1,2);
double z3= Math.Pow(z2-z1,2);
double Line= Math.Sqrt(x3+y3+z3);
Console.WriteLine($"Расстояние от точки А ({x1},{y1},{z1}) до точки В ({x2},{y2},{z2}) равно {Line:F2}");

