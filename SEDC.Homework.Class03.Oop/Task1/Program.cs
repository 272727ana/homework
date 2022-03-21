using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 3, 7, 3, 2, 8 };

            int sum = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    sum += numbers[i];
                   
                }
             
            }
            Console.WriteLine(sum);
        }
    }
}



