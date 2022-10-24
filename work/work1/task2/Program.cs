// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Pront(string massage)
{
Console.Write(massage);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}


int nam1 = Pront("Введите 1 число >");
int nam2 = Pront("Введите 2 число >");
int nam3 = Pront("Введите 3 число >");



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