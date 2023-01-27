// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("эта программа будет высчитывать точку пересечения двух прямых");
Console.WriteLine("Введите начальную точку прямой AB");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечную точку прямой AB");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальную точку прямой CD ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечную точку второй прямой ");
int k2 = Convert.ToInt32(Console.ReadLine());

if (b1 == b2 && k1 == k2)
{
    Console.WriteLine($"Прямые AB и CD совпадают");
}
else
{
    double x = (double)(b1 - b2) / (k2 - k1);
    double y = (double)k1 * (x) + b1;
    
        Console.WriteLine($"Точка пересечения прямых AB и CD будет иметь координаты: ({x};{y})");
    
}

// Console.Write("Точка пересечения прямых AB и CD будет иметь координаты ");
// Console.Write("(");
// Console.Write((double)(b1 - b2) / (k2 - k1));
// Console.Write(";");
// Console.Write((double)k1 * (b1 - b2) / (k2 - k1) + b1);
// Console.Write(")");