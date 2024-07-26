using System;

class Entrypoint
{
    static void Main()
    {
        //int type holds 32bits numbers

        int someInteger = 5;

        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        uint someUInteger = 1; // unsigned int

        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        byte someByte = 255; // from 0 to 255

        sbyte nagativeByte = -1; // signed bytes -128 to 127

        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);

        long someVeryLongNumber = 34567890;

        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        ulong noNegativeLongNumber = 0;

        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(ulong.MaxValue);
    }
}