using System;

namespace Task1.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SwapNumbers");

            int firstNum = 5;
            int secondNum = 8;
            int temp;

            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First number:" + firstNum);
            Console.WriteLine("Second number:" + secondNum);
        }
    }
}
