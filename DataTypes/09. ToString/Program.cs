class EntryPoint
{
    static void Main()
    {
        int someCrazyNumber = 45678;
        System.Console.WriteLine(someCrazyNumber);
        System.Console.WriteLine(someCrazyNumber.GetType());

        string theNumberwasStringed = someCrazyNumber.ToString();
        System.Console.WriteLine(theNumberwasStringed);
        System.Console.WriteLine(theNumberwasStringed.GetType());
        System.Console.WriteLine(theNumberwasStringed[3]);

        bool theTrue = true;

        System.Console.WriteLine(theTrue.ToString()[2]);
    }
}