using System;

class Program
{
    // Функція для обчислення НСД з використанням алгоритму Евкліда
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Обчислення і виведення НСД
        int result = GCD(num1, num2);
        Console.WriteLine("Найбільший спільний дільник: " + result);
    }
}
