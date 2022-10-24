// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число >");
string а = Console.ReadLine();
int nam1 = Convert.ToInt32(а);

int min_nam1 = nam1 * -1;

int ty = 0;
int mi = nam1 *2;

while(ty < mi)
{
    Console.WriteLine(min_nam1 ++);
    ty++;
}
Console.WriteLine(min_nam1);

