// Задача 1.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

bool Validate(int intN)
{
    if (intN / 100000 == 0 && intN / 10000 > 0) return true;
    else return false;
}

int Reverse(int intN)
{
    int intTemp = 0;
    while (intN > 0)
    {
        intTemp = intTemp * 10 + intN % 10;
        intN = intN / 10;
    }
    return intTemp;
}

bool IsPalin(int intN)
{
    if (intN == Reverse(intN)) return true;
    else return false;
}

System.Console.WriteLine("Эта программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
int intN = Prompt("Введите пятизначное число: ");
if (Validate(intN))
{
    if (IsPalin(intN))
    {
        System.Console.WriteLine($"Число {intN} является палиндромом.");
    }
    else
    {
        System.Console.WriteLine($"Число {intN} не является палиндромом.");
    }
}
else
{
    System.Console.WriteLine("Введено не пятизначное число, попробуйте снова.");
}