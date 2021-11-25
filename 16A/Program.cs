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


            //Staattisen metodin kutsu
            PoistaValitut(kaupungit, 'K');

            //Lopuksi:
            Console.WriteLine("Kokoelmaan jäi: ");

            foreach (var item in kaupungit)
            {
                Console.Write(item+" ");
            }
            
        }
        //Staattisen metodin toteutus
        public static void PoistaValitut(List<string> sunKaupungit, char kirjain)
        {
            var poistetaan = sunKaupungit.Where(item => item.StartsWith(kirjain));
            int lkm = sunKaupungit.Count;
            if (poistetaan.Any())
            {
                for (int i = 0; i < lkm; i++)
                {
                    if (sunKaupungit[i].StartsWith("K"))
                    {
                        Console.Write("Poistetaanko {0} (K/E)?: ", sunKaupungit[i]);
                        string valinta = Console.ReadLine().ToUpper();
                        if (valinta.StartsWith("K"))
                        {
                            Console.WriteLine("Poistettiin {0}. ", sunKaupungit[i]);
                            sunKaupungit.Remove(sunKaupungit[i]);
                            lkm = lkm - 1;
                            i = i - 1;
                        }
                    }
                }
            }
            else
                Console.WriteLine("Ei löytynyt kaupunkeja.");
        }
    }
}
