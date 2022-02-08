using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ArrayToCSV
    {


        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "Hii";
            files[0, 1] = "this is";
            files[0, 2] = "Santhu ";
            files[0, 3] = "idiot";
            files[0, 4] = "rit";

            files[1, 0] = "you";
            files[1, 1] = "are";
            files[1, 2] = "very good";
            files[1, 3] = "Santhosh";
            files[1, 4] = "S";

            StreamWriter sw = File.CreateText("OutputText.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");

                }

                sw.Write("\n");

            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("success");


        }
    }
}
