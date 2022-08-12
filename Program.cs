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
            String navn = "Jens Ole Hansen";
            int antalTegn = navn.Length;
            //Console.WriteLine("Der er {0} tegn i variabler", antalTegn);
            //Console.WriteLine("Formatet er {0}", navn.Substring(0,4));

            for (int pos = 0; navn.Substring(pos, 1) != " "; pos = +1)
            {
                Console.WriteLine(navn.Substring(pos, 1));
            }
           
            Console.Write("Done!"); Console.ReadKey();
        }
    }
}
