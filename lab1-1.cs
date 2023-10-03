using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введіть y: ");
        int y = int.Parse(Console.ReadLine());

        double z = Math.Round(1 / (Math.Pow(x, 3) - Math.Pow(y, 3)) - Math.Sqrt(2 * x), 3);
        Console.WriteLine(z);
    }
}
