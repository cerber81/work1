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
    int lastDigit = (number / 10) % 10;
    Console.Write($"Вторая цифра числа {number} является {lastDigit}");
}