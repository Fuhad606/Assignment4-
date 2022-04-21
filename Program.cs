using System;

namespace week4assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple app designed by Fuhad to check if a particular sum is less than 100");
            Console.Write("Input your first number...");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Input your second nuumber...");
            int secondnumber = int.Parse(Console.ReadLine());
            int Result = firstnumber + secondnumber;
            Console.WriteLine("The sum of" + firstnumber + "and" + secondnumber +   "is"   + Result);

            if (Result < 100)
            {
                Console.WriteLine("True because sum is less than 100");
            }
            else if (Result > 100)
            {
                Console.WriteLine("False because result is greater than 100");
            }


        }
    }
}
