// Вычислить значения функции y=f(x) для значений аргумента x, изменяющегося в интервале от xнач до xкон с шагом  ∆x, 
// и заданных параметров a и b с исполь-зованием операторов цикла while.
// Исходные данные для отладки программы (xнач, xкон, ∆x , a, b), выбрать самостоятельно из интервала значений,
//  где заданные функции определены. Ре-зультаты (значения аргумента x и функции y)  оформить в виде таблицы, стро-ки таблицы пронумеровать.
//   В заголовке таблицы вывести исходные данные.

double ReadData(string message)
{
    Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double a = ReadData("Введите пораметр a >");

double b = ReadData("Введите пораметр b >");

double xn = ReadData("Введите x начальное >");

double xk = ReadData("Введите x конечное >");

double xh = ReadData("Введите шаг x >");

double n = 0;

System.Console.WriteLine("-------------------------------------------");
System.Console.WriteLine("|                Исходные данные          |");
System.Console.WriteLine("-------------------------------------------");
System.Console.WriteLine("|   №   |      X      |         Y         |");
System.Console.WriteLine("-------------------------------------------");


while (xn < xk)
{
    double x = xn;
    double tanX = Math.Tan(x);// Это выражение равно tgx

double sqrtTanX = Math.Pow(tanX, 2);//Это выражение (tgX)^2

double exp = Math.Exp(a*x);// Это выражение равно exp^(a*x)

double y = (sqrtTanX - b) / exp;

n = n+1;

xn = xn +xh;


System.Console.WriteLine($"|  {n}    |    {xn}       |     {y}    |");

}