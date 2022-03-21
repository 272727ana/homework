using System;

namespace SEDC.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StudentGroup");

            string[] studentsG1 = new string[]
            {
                "Zdravko",
                "Petko",
                "Stanko",
                "Branko",
                "Trajko"
            };

            string[] studnetsG2 = new string[]
            {
                "Saven",
                "Marko",
                "Ana",
                "Sandra",
                "Kate"
                };

            Console.WriteLine("Enter 1 to see the students in G1 or enter 2 to see the students in G2");
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out int num);

            if (isValid)
            {
                if(num == 1)
                {
                    Console.WriteLine("studentsG1");
                    foreach(string name in studentsG1)
                    {
                        Console.WriteLine(name);
                    }
                }
                else if (num == 2)
                {
                    Console.WriteLine("studentsG2");
                    foreach (string name1 in studnetsG2)
                    {
                        Console.WriteLine(name1);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Enter 1 to see the students in G1 or enter 2 to see the students in G2");
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            

        }
    }
}
