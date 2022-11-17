// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



int Prompt(string message)
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}

int[] CreateArray(int Length = 8)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(1, 10);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int Length = Prompt("Введите кол. чисел массива :");

int min(int[] array)
{
    int min = 10;
    for (int i = 0; i < Length; i++)
    {
        if (array[i] < min)
        {
            min= array[i];
        }
    }
    return min;
}

int max(int[] array)
{
    int max = 0;
    for (int i = 0; i < Length; i++)
    {
        if (array[i]> max)
        {
            max= array[i];
        }
    }
    return max;
}


System.Console.Write("Случайный трехзначный массив: ");
int[] array = CreateArray(Length);
printArray(array);

System.Console.WriteLine();
System.Console.Write($" Разница > {max(array) - min(array)} ");
