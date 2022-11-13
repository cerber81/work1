//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}
int A = Prompt("Введите число A :");
int B = Prompt("Введите число B :");
int rezalt = A;
for (int i = 0;i < B -1;  i++) rezalt = rezalt * A;
Console.WriteLine(rezalt);
