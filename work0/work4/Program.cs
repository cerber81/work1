Console.Clear();
// Console.SetCursorPosition (10, 4);
// Console.WriteLine("+");

int x1 = 5;
int y1 = 1;
int x2 = 5; 
int y2 = 30;
int x3 = 120; 
int y3 = 30;

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");
Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");
Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");


int x = x1, y = y2, count = 0, what = new Random().Next(0,3);

while (count < 10000)
{
    if (what == 0)
    {
        x = (x + x1)/2;
        y = (y + y1)/2;
    }
    if (what == 1)
    {
        x = (x + x2)/2;
        y = (y + y2)/2;
    }
    if (what == 2)
    {
        x = (x + x3)/2;
        y = (y + y3)/2;
    }

            what = new Random().Next(0,3);
            Console.SetCursorPosition(x,y);
            Console.WriteLine("+");
            count = count + 1;
}
