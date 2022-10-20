// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите 1 число >");
string а = Console.ReadLine();
int nam1 = Convert.ToInt32(а);

Console.Write("Введите 2 число >");
string b = Console.ReadLine();
int nam2 = Convert.ToInt32(b); 


Console.Write("Введите 3 число >");
string с = Console.ReadLine();
int nam3 = Convert.ToInt32(с); 

int max = 0;

if(nam1 > nam2 )
{
max = nam1;
}
if(nam1 < nam2 )
{
max = nam2;
}

if(nam3 > max )
{
max = nam3;
}
Console.Write(max);