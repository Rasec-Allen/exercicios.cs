using System;

public class SumOfTwoNumbers 
{
    static int Sum(int x, int y) 
    {
        return x + y;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());  
        int z = Sum(number1, number2);
        Console.WriteLine(z);
    }
}
