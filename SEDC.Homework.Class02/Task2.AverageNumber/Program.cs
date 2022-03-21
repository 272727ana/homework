using System;

namespace Task2.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Number");

            int firstNum = 10;
            int secondNum = 15;
            int thirdNum = 20;
            int fourNum = 30;

            int calculate = firstNum + secondNum + thirdNum + fourNum;

            int average = calculate / 4;

            Console.WriteLine("The average of 10, 15, 20 and 30 is:" + average);
        }
    }
}
