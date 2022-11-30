// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message) // ввод данных
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}

void PrintNumbers(int m, int n, int sum) //натуральные элементы в промежутке от M до N
{
    if (n < m)
    {
        System.Console.WriteLine(sum);
        return;
    }
  
    PrintNumbers(m + 1, n, sum + m);

}
int m = Prompt ("Введите число M : ");
int n = Prompt ("Введите число N : ");

int sum = 0;


PrintNumbers(m, n, sum);