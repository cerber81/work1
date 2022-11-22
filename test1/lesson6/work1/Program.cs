// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int Prompt(string message) // ввод данных
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}

int[] CreateArray(int Length = 5) //  создание массива
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(1, 10);
    }
    return tempArray;
}

void printArray(int[] intArray) // вывод массива 
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int Length = Prompt("Введите кол. чисел массива :");

int[] array = CreateArray(Length);

void masnev(int[] array)  //замена чисел масива
{
for (int i = 0; i < Length; i++)
{
    array[i] = Prompt($"Введите {i+1} число: ");
}
}


int pol(int[] array) // больше нуля
{
int pol = 0;
for (int i = 0; i < Length; i++)
{
    if (array[i] > 0)
    {
        pol += 1;
    }
}
 return pol;
}

masnev(array);
System.Console.Write("Числа которое вы ввели: ");
printArray(array);
System.Console.WriteLine(" ");
System.Console.Write($"Кол больше нуля: {pol(array)}");