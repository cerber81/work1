// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// функция ввода числа с консоли
int Prompt(string message)
{
System.Console.Write(message); //выводит сообщение в консоли
return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}

int number = Prompt("Введите число: ");
int kol =1;
int p = number;
int n = number;
int b = 0;
int z = 0;

for (int i = 0; i < kol; i++)
{
    if (number>10)
    {
        number/=10;
    kol++;
    }
z = n%10;
n=n/10;
b = (b*10)+z;
}
Console.WriteLine($"Резудьтат : {b} ");
Console.WriteLine($"Резудьтат : {p} ");

if (b == p)
{
    Console.Write($"Да");
}
else{
   Console.Write($"Нет");
}