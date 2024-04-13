using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag_1___Novo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkomna till denna pensionssimulator");  // Hälsar användaren välkommen och berättar ämnet.
            
            Console.WriteLine("Vad heter du i förnamn?");                // Frågar användaren om vad den heter
            String name = Console.ReadLine();                            //  Sparar användarens namn som variabeln "namn"

            Console.WriteLine("Hur gammal är du?");                      // Frågar om användarens ålder.
            string stringNr = Console.ReadLine();                        // Sparar användarens åldern som variabel "stringNr" 
            int nr = Convert.ToInt32(stringNr);                          // Typomvandlar String till Int så att textsträngen blir siffror som Användaren har skrivit.
            nr = 65 - nr;                                                // Gör en ekvation talar om för datorn att Pensionen = 65 år(Pensionsåldern) - Användarens ålder 
            
            Console.WriteLine("Hej" + " " + name + " " + "du kommer att att gå i pension om" + " "  + nr + " " + "år");  /*  Skriver ut Namn + Ålder och återstående år
                                                                                                                             till pensionen. */

        }
    }
}
