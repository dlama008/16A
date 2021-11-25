using System;
using System.Collections.Generic;
using System.Linq;

namespace _16A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method extension syntax
            List<string> kaupungit = new List<string>() {  "Mikkeli",
                "Savonlinna", "Jyväskylä", "Joensuu", "Kauhajoki", "Kouvola",
                "Kannus", "Kajaani", "Kalajoki", "Kangasala", "Akaa"};
            var poistetaan = kaupungit.Where(item => item.StartsWith("K"));
            int lkm = kaupungit.Count;
            if (poistetaan.Any())
            {
                for (int i = 0; i < lkm; i++)
                {
                    if (kaupungit[i].StartsWith("K"))
                    {
                        Console.Write("Poistetaanko {0} (K/E)?: ", kaupungit[i]);
                        string valinta = Console.ReadLine().ToUpper();
                        if (valinta.StartsWith("K"))
                        {
                            Console.WriteLine("Poistettiin {0}. ", kaupungit[i]);
                            kaupungit.Remove(kaupungit[i]);
                            lkm = lkm - 1;
                            i = i - 1;
                        }
                    }
                }
            }
            else
                Console.WriteLine("Ei löytynyt kaupunkeja.");

            //Lopuksi:
            Console.WriteLine("Kokoelmaan jäi: ");

            foreach (var item in kaupungit)
            {
                Console.Write(item+" ");
            }
            
        }
    }
}
