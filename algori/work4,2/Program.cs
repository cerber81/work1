int ReadData(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//Создание массива 1
Console.Write("Введи размер 1 массива: ");
int[] array1 = new int[int.Parse(Console.ReadLine())];

int i = 0;

//Создание массива 2
Console.Write("Введи размер 2 массива: ");
int[] array2 = new int[int.Parse(Console.ReadLine())];

int z = 0;

//Заполнение массива

for (int b = 0; i < array1.Length; b++)
{
    array1[i] = ReadData($"Введите значение 1 масива, ячейки № {b + 1} >");
    i++;
}



for (int d = 0; z < array2.Length; d++)
{
    array2[z] = ReadData($"Введите значение 2 масива, ячейки № {d + 1} >");
    z++;
}


//Вывод массива 

Console.Write("Исходный данные массива 1: ");
for (int t = 0; t < array1.Length; t++)
{ Console.Write(array1[t] + " "); }

Console.WriteLine(" ");

Console.Write("Исходный данные массива 2 : ");
for (int a = 0; a < array2.Length; a++)
{ Console.Write(array2[a] + " "); }

//из второго масива все четные числа
int in1 = 0;
int colarray3 = 0;
while (in1 < array2.Length)
{
    if (array2[in1] % 2 == 0)
    {
        colarray3++;
    }
    in1++;
}
//находим Max число из масива 2
int maxarray2 = array2.Max();

int in2 = 0;

while (in2 < array1.Length)
{
    if (array1[in2] < maxarray2)
    {
        colarray3++;
    }
    in2++;
}
Console.WriteLine(" ");
//Создание массива 3
int[] array3 = new int[colarray3];

// заполнение масива 3

int in3 = 0;

int numb1 = 0;

while (in3 < array2.Length)
{
    if (array2[in3] % 2 == 0)
    {
        array3[numb1] =array2[in3];
        numb1++;
    }
    else{
        numb1++;
    }
    in3++;
}



int in4 = 0;

while (in4 < array1.Length)
{
    if (array1[in4] < maxarray2)
    {
         array3[numb1] =array1[in4];
        numb1++;
    }
    else{
        numb1++;
    }
    in4++;
}
//вывод массива 3
Console.Write("Данные массива 3: ");
for (int p = 0; p < array3.Length; p++)
{ Console.Write(array3[p] + " "); }