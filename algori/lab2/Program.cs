int ReadData(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
//Создание массива 1
Console.Write("Введи размер массива: ");
int[] array1 = new int[int.Parse(Console.ReadLine())];

int i = 0;
//Заполнение массива

for (int b = 0; i < array1.Length; b++)
{
    array1[i] = ReadData($"Введите значение масива № {i + 1} >");
    i++;
}


//Вывод массива 

Console.Write("Исходный массив: ");
for (int t = 0; t < array1.Length; t++)
    Console.Write(array1[t] + " ");

// Средне ар. чисел полож чисел на нечетных числах
int f = 0;
int c = 0;
int sum = 0;
while (c < array1.Length)
{
    if (array1[f] >= 0)
    {
        if ((f +1) % 2 == 1)
        {
            sum += array1[f];
        }
        f++;
    }
    else
    {
        f++;
    }
    c++;
}
Console.WriteLine($"");
Console.WriteLine($" Сума чисел равна : {sum}");