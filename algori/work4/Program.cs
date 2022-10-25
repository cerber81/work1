double ReadData(string message)
{
    Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}



double[] array = new double[5];
int i = 0;

while (i < 5)
{

    array[i] = ReadData($"Введите значение масива № {i + 1} >");

    i++;
}
int b = 0;
while (b < 5)
{
    if (array[b] % 2 == 0)
    {

        Console.WriteLine("ДА");
        b++;
    }

}







