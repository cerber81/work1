// Напишите программу вычисления модуля числа.
Console.Write("Введите число >");
string а = Console.ReadLine();
int nam1 = Convert.ToInt32(а);

int mod = nam1;

if(mod < 0)
{
    nam1 = - nam1;
}
Console.Write(nam1);