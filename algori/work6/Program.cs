string input(string message)
{
    Console.Write(message);
    string number = Convert.ToString(Console.ReadLine());
    return number;
}
//­	Определения длины строки
int b =0;
string message = input("Введите сроку : ");
 
for(var i =0; i < message.Length; i++)
{
    b++;
    
}

Console.WriteLine($"Всего сим: {b}");

//­	ф. посимвольного ввода строки до нажатия клавиши ENTER







char ch = 'о';
int indexOfChar = message .IndexOf(ch); // равно 4
message[indexOfChar] ="*";

Console.WriteLine(indexOfChar);
 



// Замена
// Чтобы заменить один символ или подстроку на другую, применяется метод Replace:

//  string text = "хороший день";
 
// text = text.Replace("хороший", "плохой");
// Console.WriteLine(text);    // плохой день
 
// text = text.Replace("о", "");
// Console.WriteLine(text);    // плхй день