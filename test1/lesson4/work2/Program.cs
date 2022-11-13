// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int Prompt(string message)
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}
int A = Prompt("Введите число :");

int rezalt = 0;

int ost = 0;
while (A >= 1)
{
    ost = A % 10;
    A = A / 10;
    rezalt = rezalt + ost;
}
Console.WriteLine(rezalt);
