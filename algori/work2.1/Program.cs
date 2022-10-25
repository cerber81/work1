double ReadData(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double x = ReadData("Введите переменную Х");

if (x >= 5)
{
    
double lg = Math.Log(2* x);
double sqrtTanZ = Math.Pow(lg, 2); //Это выражение (lg2x)^2
System.Console.Write(lg);
}

else if (x <= -2)
{
    System.Console.WriteLine((2 * x) * x);

}
else
{
    
double sin = Math.Sin(x);         // Это выражение равно sin x
    System.Console.WriteLine(sin);


}

