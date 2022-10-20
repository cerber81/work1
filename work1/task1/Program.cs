// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число >");
string а = Console.ReadLine();
int nam1 = Convert.ToInt32(а);

Console.Write("Введите второе число >");
string b = Console.ReadLine();
int nam2 = Convert.ToInt32(b); 

if(nam1 < nam2)
{
Console.Write(nam2);
}

if(nam1 > nam2)
{
Console.Write(nam1);
}