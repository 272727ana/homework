using System;

namespace SEDC.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfEven!");

            int[] numbers = new int[] { 4, 3, 7, 3, 2, 8 };

            int sum = 0;
            

            foreach (int result in numbers)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLines(sum += result);
                }
                else
                {
                    Console.WriteLine("Odd numbers:" + result);
                }

            

           
        }
    }
}
