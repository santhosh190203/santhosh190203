using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to find sin value:");
            float num = Convert.ToSingle(Console.ReadLine());
            SinOfNumber son = new SinOfNumber();
            float sin = son.sin(num);
            Console.WriteLine("Sin value of " + num + "is:" + sin);
            Console.ReadLine();
        }
    }
    class SinOfNumber
    {
        int factorial(int fact)
        {
            int i;
            int k = 1;
            for (i = 1; i <= fact; i++)
            {
                k = k * i;
            }
            return k;
        }
        float Pow(float num, int pow)
        {
            float result = 1;

            if (pow > 0)
            {
                for (int i = 1; i <= pow; ++i)
                {
                    result *= num;
                }
            }
            else if (pow < 0)
            {
                for (int i = -1; i >= pow; --i)
                {
                    result /= num;
                }
            }

            return result;
        }
        public float sin(float num)
        {
            float sum = 0;
            int i, j = 0;
            for (i = 0; i <= num + 10; i++)
            {
                if (i % 2 != 0)
                {
                    j++;
                    float numaretor = Pow(num, i);
                    float denominator = factorial(i);
                    float term = numaretor / denominator;
                    if (j % 2 != 0)
                    {
                        sum = sum + term;
                    }
                    else
                        sum = sum - term;
                }
            }
            return sum;
        }

    }
}
