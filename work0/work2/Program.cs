// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
Console.Write("Введите первое число >");
string а = Console.ReadLine();
int nam1 = Convert.ToInt32(а);

Console.Write("Введите второе число >");
string b = Console.ReadLine();
int nam2 = Convert.ToInt32(b);

if (nam1 * nam1 == nam2)
{
    Console.Write("является");
}
else
{
     Console.Write("не является");
}