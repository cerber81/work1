// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//  Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98
int Prompt(string message)

{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = new Random().Next(100, 1000);


Console.Write($"Число после генирации :{number}");

int Pervoe(int number){
    int ost = number / 100;
    return number;
}

int Ostatok(int number){
    int ost = number % 10;
    return number;
}


Console.WriteLine("");

Console.Write($"Число остаток :{Pervoe(number)}{ Ostatok(number)}");

