using System;


namespace Assignment
{
   public class celciusconvert
    {
        public static void convertion()
        {
            Console.WriteLine("Enter the amount of Celcius");
            int celcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kelvin = {0}", celcius + 273);
            Console.WriteLine("fahrenhiet = {0}", celcius * 18 / 10 + 32);
        }
        public static void Main(string[] args)
        {
            convertion();  
        }
    }
}
