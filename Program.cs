using System;
using System.Threading;

namespace more_variable_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Her kaldes vores metode
            //nameLength();
            firstNameLastName();

        }

        //Vores metode
        static void nameLength()
        {

            //Her defineres vores variable "name"
            String name = "Jens Ole Hansen.";


            //Her defineres en variable, som bruges til at vise antal charactere i vores string "name"
            int charAmmount = name.Length;


            //Her udskriver vi vores charAmmount variable, som viser at vi har 15 chars i vores "name" String
            Console.WriteLine("Der er {0} tegn i variabler", charAmmount);


            //Her benyttes Substring metoden. Denne metode lader os udskrive de første 4 chars i vores String
            //Argumenterne/parametrene indukeres på de to koordinater: "(0, 4)".
            //Første parameter indikerer hvor vi starer vores substring (i dette tilfælde position 0)
            //Anden parameter indikerer hvor mange chars som skal udskrives (i dette tilfælde 4)
            //Dette resulterer i en udskrift af de første 4 chars i vores String, dvs: "Jens" (se "name" String).
            Console.WriteLine("Formatet er {0}", name.Substring(0, 4));


            //Her benytter vi os af et for-loop, hvis ønskede effekt skal være at udskrive String, men at stoppe udskriften ved mellemrum
            //Vores udskrift starter ved position 0 i vores String
            //Herefter beder vi om at få udskrevet 1 char ad gangen, indtil vi når mellemrum (se != " ")
            //Dette lykkedes ved at vi incrementer vores pos variable med +1, hver gang den har udskrevet én char (pos = pos + 1)
            for (int pos = 0; name.Substring(pos, 1) != " "; pos = pos + 1)
            {

                //Her udskrives vores String
                Console.Write(name.Substring(pos, 1));
            }


            //Her afsluttes vores console udskrift med en "Done!" String.
            //Til slut kan man vælge at lukke sin console ned igen, ved at trykke på "any key"
            Console.WriteLine("");
            Console.WriteLine("Done!"); Console.ReadKey();
        }

        static void firstNameLastName()
        {
            String name = "Henrik Johansen";
            String lastName = "";
            int numKey = name.Length;

            for (int pos = 0; name.Substring(pos, 1) != " "; pos = pos + 1)
            {
                Console.Write(name.Substring(pos, 1));
            }


            int lastPos = name.Length - 1;

            for (int pos = name.Length - 1; name.Substring(pos, 1) != " "; pos = pos - 1)
            {
                lastName = name.Substring(pos, 1) + lastName;


            }
            Thread.Sleep(500);
            Console.Write(" " + lastName);
        }
    }
}
