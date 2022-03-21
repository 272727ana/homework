using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter birthdayDate");
            bool flag = true;
            while (flag)
            {
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int birthdayDate);
                if (isValid)
                {
                    Console.WriteLine(AgeCalculator(birthdayDate));
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Enter valid birthday date");
                }

            }
               

            



        }

        public static int AgeCalculator(int dateOfBirth)
        {

            DateTime date = new DateTime().Year;
            int currentDate = int.Parse(date);
            int result = date - dateOfBirth;




            return result;
        }

       



    }
}
