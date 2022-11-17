// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
        if (array[i] % 2 == 0)
        {
            rezalt++;
        }
    }
    return rezalt;
}




System.Console.Write($"Случайный трехзначный массив из {Length} элементов : ");
int[] array = CreateArray(Length);
printArray(array);

System.Console.WriteLine();
System.Console.Write(parity(array));

