// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
        tempArray[i] = new Random().Next(100, 1000);
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

int parity(int[] array)
{
    int rezalt = 0;
    for (int i = 1; i < Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            rezalt+= array[i];
        }
    }
    return rezalt;
}



System.Console.Write("Случайный трехзначный массив: ");
int[] array = CreateArray(Length);
printArray(array);

System.Console.WriteLine();
System.Console.Write(parity(array));
