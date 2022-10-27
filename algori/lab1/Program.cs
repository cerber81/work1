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

System.Console.WriteLine("-----------------------------------------------------");
System.Console.WriteLine("|                Исходные данные                     ");
System.Console.WriteLine("-----------------------------------------------------");
System.Console.WriteLine("|  Формула   |   №   |      X      |         Y         |");
System.Console.WriteLine("-----------------------------------------------------");

for (double xn = ReadData("Введите x начальное>"); xn <= xk; xn += xh)
{
    if (x > 0 && x != 0)
    {
      
        double sqrtTanZ = 1-3*x; //Это выражение (lg2x)^2
        
        System.Console.WriteLine($"|  1-3x     |  {n}    |    {xn}       |     {sqrtTanZ}    |");
        n++;
    }
    else if (x <= 1)
    {
        double sin = Math.Sin(x);
        System.Console.WriteLine($"x-sin x");
        double y =  (x*x) - sin ;
        n++;
        System.Console.WriteLine($"|  x-sin x  |  {n}    |    {xn}       |     {y}    |");
    }
    else
    {
        double sin = Math.Cos(x);         // Это выражение равно sin x
        System.Console.WriteLine($"cos x");
        n++;
        System.Console.WriteLine($"|  cos x     |  {n}    |    {xn}       |     {sin}    |");
    }
}
