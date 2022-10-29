Console.WriteLine("Введите натуральное число");
int x = Convert.ToInt32 (Console.ReadLine ());

int i = 0;
int y = i + 1;

while (y < x)
{
    if (y % 2 == 0)
    Console.Write (y + ", ");
    y ++;
}
