// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Write("Введите первое число >");
string а = Console.ReadLine();
int nam1 = Convert.ToInt32(а);



if (nam1 == 1)
{
    Console.Write("Понедельник");
}
if (nam1 == 2)
{
    Console.Write("Вторник");
}
if (nam1 == 3)
{
    Console.Write("Среда");
}
if (nam1 == 4)
{
    Console.Write("Четверг");
}
if (nam1 == 5)
{
    Console.Write("Пятница");
}
if (nam1 == 6)
{
    Console.Write("Суббота");
}
if (nam1 == 7)
{
    Console.Write("Воскресенье");
}
if (nam1 < 1 || nam1 > 7)
{
    Console.Write("ошибка");
}
