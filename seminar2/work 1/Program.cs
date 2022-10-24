// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
int Prompt(string message)

{
System.Console.Write(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

bool ValidateNumber(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Число не трехзачное");
        return false;
    }
    return true;
}

int number = Prompt("Введите трхзначное число:");
if (ValidateNumber(number))
{
    int lastDigit = number % 10;
    Console.Write($"Последняя цифра числа {number} является {lastDigit}");
}