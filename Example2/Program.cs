Console.WriteLine("Введите натуральное число");
int x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int y = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int z = Convert.ToInt32 (Console.ReadLine());
int max = x;

if (x > max) max = x;
if (y > max) max = y;
if (z > max) max = z;

Console.Write ("Максимальное число = ");
Console.WriteLine (max);
