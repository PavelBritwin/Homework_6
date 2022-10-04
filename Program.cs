// Task 43
// y = k1 * x + b1
// y = k2 * x + b2
// x * k1 + b1 = x * k2 + b2
// x = b2 - b1 / k1 - k2

Console.WriteLine("Укажите коэффициенты для первого уравнения: ");
double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите коэффициенты для второго уравнения: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения прямых: {x}; {y}");
