using System;

namespace Assignment
{
    class AverageNumbers
    {
       public static void Main(string[] args)
        {
            int PostiveSum = 0;
            int NegetiveSum = 0;
            int PostiveCount = 0;
            int negetiveCount = 0;

            for(int i=0; i < 10 ; i++)
            {
                Console.WriteLine("Enter the Numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                if(n > 0)
                {
                    PostiveCount += 1; //postive count = postive count +1
                    PostiveSum += n;
                }
                else
                {
                    negetiveCount += 1;
                    NegetiveSum += n;

                }
            }

            Console.WriteLine($"The Average of Postive numbers: {PostiveSum/PostiveCount}" +
                $"\n The Average of Negative Numbers :{NegetiveSum/negetiveCount}");
            
        }


    }
}
