//Вычислить сумму квадратов положительных элементов, расположенных в столбцах с номерами, кратными 3.
int input(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
//Задаем количество столбцов и строк
int col1 = input("Введите количество строк масива > ");
int col2 = input("Введите количество стобцов масива > ");

int[,] numbers = new int[col1, col2];

//Заводим значение в массив

int n = 0;

int z = 0;

for (int m = 0; m <= col2 && n <= col1; m++)
{
    if (m < col2 && n < col1)
    {
        Console.WriteLine($"Введите в {n + 1} строке число для столбца {z + 1}: ");
        numbers[n, m] = Convert.ToInt32(Console.ReadLine());
        z++;
    }
    else
    {
        z = 0;
        m = -1;
        n++;
    }
    Console.WriteLine();
}

//Выводим данные массива
int qw = 0;

for (int k = 0; k <= col2 && qw <= col1; k++)
{
    if (k < col2 && qw < col1)
    {
        Console.Write(numbers[qw, k] + " ");
    }
    else
    {
        Console.WriteLine();
        k = -1;
        qw++;
    }

}

//Вычислить сумму квадратов положительных элементов, расположенных в столбцах с номерами, кратными 3.
int kr = 1;
int ind2 = 0;
int ind3 = 0;
int ind4 = 1;
int sum = 0;

while (kr <= col2)
{
    if (numbers[ind2, ind3] >= 0 && numbers[ind4, ind3] >= 0)
    {
        if (kr % 3 == 0)
        {
            sum = numbers[ind2, ind3] + numbers[ind4, ind3] + sum;
            
            Console.WriteLine($"вывод kr {kr}");
        }
        else
        {
            
        }
        Console.WriteLine("да");
    }
    else
    {
        ind3++;
    }
    kr++;


}
Console.WriteLine($"Cумма квадратов :{sum*2}");