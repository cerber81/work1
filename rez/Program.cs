
void main3(string[] people, string[] main)
{
    int h = 0;
    for (int i = 0; i < people.Length; i++)
    {
        for (int j = 3; j >= people[i].Length; i++)
        {
            // Console.WriteLine(people[i]);
            main[h] = people[i];
            h++;
        }
    }
}

void mainprint(string[] main)
{
    for (int i = 0; i < main.Length; i++)
    {
        Console.WriteLine(main[i]);
    }
}
string[] mas = { "men", "hanig", "-2", "Bob", "hanig" };
string[] main = new string[4];

main3(mas, main);
mainprint(main);