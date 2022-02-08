using System;

namespace Assignment
{
    public  class Starpattern
    {
        public static void Main(string[] args)
        {
            for (int row = 1; row <= 6; row++) //preIncrement
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
