using System;

class Program
{
    static void Main()
    {
        char[,] data =
        {
            { 'A', 'b', 'C' },
            { 'd', 'e', 'F' },
            { 'g', 'H', 'i' }
        };

        CharMatrix cm = new CharMatrix(data);

        Console.WriteLine("The main diagonal: " + cm[0]); // A, e, i
        Console.WriteLine("The side diagonal: " + cm[1]); // C, e, g
        Console.WriteLine("Number of vowels: " + cm.VowelCount); // 3 (A, e, i)
    }
}
