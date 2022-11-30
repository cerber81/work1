// Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message) // ввод данных
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}

int m = Prompt("Введите число M : ");
int n = Prompt("Введите число N : ");

void PrintNumbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    else if (m % 2 == 1)
    {
        PrintNumbers(m + 1, n);
        return;
    }
    System.Console.WriteLine(m);
    PrintNumbers(m + 2, n);

}

PrintNumbers(m, n);