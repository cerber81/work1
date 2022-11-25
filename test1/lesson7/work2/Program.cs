int Prompt(string message) // ввод данных
{
    System.Console.Write(message); //выводит сообщение в консоли
    return int.Parse(Console.ReadLine()); // считать строку с консоли и преобразовать в целое значение
}
void newarray(int[,] arr) // вывод массива
{
 Random random = new Random();
 for (int i = 0 ; i < arr.GetLength(0); i++)
            {
                for (int j = 0 ; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 99);
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
}
void FillArray(int[,] matr) // заполнение массива числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 11);//[1; 10)
        }
    }
}

int pos1 = Prompt("Введите столбец:");
int pos2 = Prompt("Введите строку:");

int n = 5; // размер массива
int m = 7; // размер массива
int[,] arr = new int[n, m];
void position(int pos1, int pos2) // найти число по пози....
{
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1 -1, pos2 -1]);
}
}

FillArray(arr);

Console.WriteLine("Исходный массив:");

newarray(arr);
position(pos1, pos2);