// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int PromptInt(string strDescription) 
{
    try
    {
        System.Console.Write(strDescription);
        int intTemp = int.Parse(System.Console.ReadLine());
        return intTemp;
    }
    catch
    {
        System.Console.WriteLine("Введено некорректное значение, попробуйте снова.");
        int intException = PromptInt(strDescription);
        return intException;
    }
}

bool IsDayIsWeekend(int intNumberOfDay)
{
    if (intNumberOfDay < 1 || intNumberOfDay >7)
    {
        System.Console.Write("Введено некорректное значение дня недели.");
        return false;
    }
    else if (intNumberOfDay < 6)
    {
        System.Console.WriteLine("Иди на работу");
        return false;
    }
    else
    {
        System.Console.WriteLine("Ура! Это выходной!");
        return true;
    }
}

System.Console.Clear();
int intNumber = PromptInt("Введите номер дня недели (от 1 - понедельник до 7 - воскресенье): ");
    if (IsDayIsWeekend(intNumber))
    {
       
    }
    else
    {
        
    }