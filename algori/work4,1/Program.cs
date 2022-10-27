double ReadData(string message)
{
    Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}



double[] array = new double[10];
int i = 0;

Console.WriteLine("Введите 10 эл.масивов");

while (i < 10)
{

    array[i] = ReadData($"Введите значение масива № {i + 1} >");

    i++;
}

double d = ReadData("Введите число D >");

double f = ReadData("Введите число F >");

int b = 0;
int col = 0;
double sum = 0;

int z = 1;

while (b < 10)
{
    if (b < 10)
    {
        if (array[b] >= d)
        {
            if (array[b] <= f)
            {
                if (b % 2 == 0)
                {
                    col++;
                    sum += array[b];
                    

                }


            }


        }
        b++;
    }


}
Console.WriteLine($"сумма всех нечетных чисел равна = {sum}");
Console.WriteLine($"количество слагаемых чисел = {col}");






