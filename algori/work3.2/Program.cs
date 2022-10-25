double ReadData(string message)
{
    Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double xk = ReadData("Введите x конечное >");
double xh = ReadData("Введите шаг x >");
double x = ReadData("Введите значение x >");

int n = 0;

System.Console.WriteLine("-------------------------------------------");
System.Console.WriteLine("|                Исходные данные          |");
System.Console.WriteLine("-------------------------------------------");
System.Console.WriteLine("|   №   |      X      |         Y         |");
System.Console.WriteLine("-------------------------------------------");

for (double xn = ReadData("Введите x начальное>"); xn <= xk; xn += xh)
{
    if (x >= 5)
    {
        double lg = Math.Log(2 * x);
        double sqrtTanZ = Math.Pow(lg, 2); //Это выражение (lg2x)^2
        System.Console.Write(lg);
        System.Console.WriteLine($"|  {n}    |    {xn}       |     {lg}    |");
        n++;
    }
    else if (x < -2)
    {
        double y = 2 * (x * x);
        n++;
        System.Console.WriteLine($"|  {n}    |    {xn}       |     {y}    |");
    }
    else
    {
        double sin = Math.Sin(x);         // Это выражение равно sin x
        System.Console.WriteLine(sin);
        n++;
        System.Console.WriteLine($"|  {n}    |    {xn}       |     {sin}    |");
    }
}
