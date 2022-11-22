// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message) // ввод данных
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}

void printArray(int[] intArray) // вывод массива 
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}


int[] CreateArray(int Length = 4) //  создание массива
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(1, 10);
    }
    return tempArray;
}

int Length = 4;

void masnev(int[] array)  //замена чисел масива
{
    array[0] = Prompt("Введите значение b1: ");
    array[1] = Prompt("Введите значение k1: ");
    array[2] = Prompt("Введите значение b2: ");
    array[3] = Prompt("Введите значение k2: ");
}
int[] array = CreateArray(Length);

int x(int array2, int array0, int array1, int array3)  //замена чисел масива
{
    var x = (array2 - array0) / (array1 - array3);
     return x;
}

int  y(int array1, int array0, int x)  //замена чисел масива
{
    var y = array1 * x + array0;
     return y;
}

var x1 = x(array[2],array[0],array[1],array[3]);
var y1 = y(array[1], array[0], x1);

masnev(array);


System.Console.WriteLine(" ");

System.Console.Write($"Точка пересечения x\\y : {x1} ; {y1}");