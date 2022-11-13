// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)

{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


bool Rr(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Число не трехзачное");
        return false;
    }
    return true;
}

int number1 = Prompt("Введите трхзначное число:");
if (Rr(number1))
{
    int lastDigit = (number1 / 10) % 10;
    Console.Write($"Вторая цифра числа {number1} является {lastDigit}");
}