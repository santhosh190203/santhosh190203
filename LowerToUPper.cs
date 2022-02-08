using System;
using System.IO;


namespace Assignment
   

{
    class LowerToUPper
    {
        static void Main()
        {

            string name = @"C:\Users\Santhosh S\source\repos\Assignment\Assignment\EmpData.csv";

            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                    {
                        fileWr.WriteLine(line.ToUpper());
                        Console.WriteLine(line.ToUpper());
                    }
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}
