// 11. Составить программу, которая бы  вычисляла степень (2-ю, 3-ю, 4-ю или 5-ю)
//  введенного числа в зависимости от выбора пользователя.


double ReadData(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double x = ReadData("Введите число для возв.в степ.");

double b = ReadData("Введите степень от 2х до 5");

if (b < 2 || b >5)
{
System.Console.WriteLine("Вы ввели неправильную степень");
}

switch (b)
{
    case 2:
System.Console.WriteLine(x*x);
break;
case 3:
System.Console.WriteLine(x*x*x);
break;
case 4:
System.Console.WriteLine(x*x*x*x);
break;
case 5:
System.Console.WriteLine(x*x*x*x*x);
break;
}