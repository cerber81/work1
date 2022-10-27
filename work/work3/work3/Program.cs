// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int PromptInt(string strMessage) 
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

System.Console.WriteLine("Эта программа принимает на вход натуральное число, выдаёт таблицу кубов чисел от 1 до N.");
int int1 = PromptInt("Введите натуральное число N: "); 
if (int1 > 0)
{
    string strResult = "";
    for (int i = 1; i <= int1; i++)
    {
        strResult = $"{strResult} {i*i*i},";
    }
    System.Console.WriteLine($"Кубы от 1 до {int1} соответственно равны:{strResult.TrimEnd(',')}");
}
else
{
    System.Console.WriteLine("Введено число меньше 1, попробуйте снова.");
}