using System;

namespace Assignment
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int num;
            bool isPrime = true;

            Console.WriteLine("Enter A Number:");
            num = int.Parse(Console.ReadLine());

            for(int i=2; i<=num/2;i++)
            {
                if(num%i==0)
                {
                    isPrime = false;
                    Console.WriteLine("The given number is not a prime number");
                    break;
                }
            }

            if(isPrime)
                Console.WriteLine("The given number is a prime number");
            Console.ReadLine();
        }

    }
}
