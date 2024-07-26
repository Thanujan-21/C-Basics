class EntryPoint
{
    static void Main()
    {
        string firstString = "C# Course";
        string secoundString = "for Beginners";
        string freeSpace = " ";
        //Console.WriteLine(firstString);
        //Console.WriteLine(secoundString);

        Console.WriteLine(firstString);
        Console.WriteLine(secoundString);

        //concatenation

        Console.WriteLine("I am taking my first "+ firstString + freeSpace + secoundString + " and I am really happy with what I am learning");
        Console.WriteLine("I am taking my first {0}{1}{2} and I am really happy with what I am learning", firstString, freeSpace, secoundString);

    }
}