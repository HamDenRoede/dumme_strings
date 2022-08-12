using System;

namespace more_variable_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            nameLength();
        }

        static void nameLength()
        {
            //Her defineres vores variable "name"
            String name = "Jens Ole Hansen.";

            //Her defineres en variable, som bruges til at vise antal charactere i vores string "name"
            int charAmmount = name.Length;

            //Her udskriver vi vores antalTegn variable
            Console.WriteLine("Der er {0} tegn i variabler", charAmmount);
            Console.WriteLine("Formatet er {0}", name.Substring(0, 4));

            for (int pos = 0; name.Substring(pos, 1) != " "; pos = pos + 1)
            {

                Console.Write(name.Substring(pos, 1));
            }

            Console.WriteLine("");
            Console.WriteLine("Done!"); Console.ReadKey();
        }
    }
}
