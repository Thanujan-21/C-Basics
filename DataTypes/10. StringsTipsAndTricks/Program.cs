using System;

//contains, Index of, Last index of, lower/uppercase, to char array, new string

class EntryPoint
{
    static void Main()
    {
        string coffeMug = "Coffe";
        string dashes = new string('-', 40);
        Console.WriteLine(dashes);

        Console.WriteLine(coffeMug.Contains("of"));
        Console.WriteLine(coffeMug.IndexOf('f'));
        Console.WriteLine(coffeMug.LastIndexOf('f'));

        Console.WriteLine(coffeMug.ToUpper());
        Console.WriteLine(coffeMug.ToLower());

        char[] coffeCharArray = coffeMug.ToCharArray();

        Console.WriteLine(coffeMug[2]);
        Console.WriteLine(coffeCharArray[2]);

        Console.WriteLine(new string('-', 40));
    }
}