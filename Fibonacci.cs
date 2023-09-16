using System;

class Program
{
    static void Main()
    {
        int n, a = 0, b = 1, i = 0, temp;
        Console.WriteLine("Ne qeder fibonacci ededini yazaq?");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Fibonacci ededleri:");
        while (i < n)
        {
            i++;
            Console.Write(a + " ");
            temp = b;
            b = b + a;
            a = temp;
        }
        Console.WriteLine();
    }
}
