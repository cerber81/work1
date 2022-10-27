static void Main(string[] args)
    {
        string str = "The Haunting of Hill House!";
       Console.WriteLine("String: " + str);
        // replacing character at position 7
        int pos = 7;
        char rep = 'p';


            string res = str.Substring(0, pos) + rep + str.Substring(pos + 1);
            Console.WriteLine("String after replacing a character: " + res);
            Console.ReadLine();

    }