using KomolyKvizApp.Services;
using System.ComponentModel.Design;

namespace Kviz_Konzol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatlap fel = new Feladatlap();
            int elertpont = 0;
            int osszpont = 0;
            Console.Write("Kérdések típusa(igaz/hamis - 0, vegyes - 1): ");
            if (Console.ReadLine() == "0")
            {

                Console.Write("Adja meg az igaz/hamis kérdések számát(max 200)! ");
                int kerdesdb = int.Parse(Console.ReadLine());


                Console.WriteLine("A kérdések témái: ");
                foreach (var item in fel.getKerdesTemak())
                {
                    Console.WriteLine(item);
                }
                Console.Write("Adja meg a kérdés témáját(az üres azt jelenti, hogy mindegy)! ");
                string tema = Console.ReadLine();

                List<KomolyKvizApp.Models.IgazHamisKerdes> kerdesek = new List<KomolyKvizApp.Models.IgazHamisKerdes>();
                if (tema == "")
                    kerdesek.AddRange(fel.getIgazHamisKerdes(kerdesdb));
                else
                    kerdesek.AddRange(fel.getIgazHamisKerdesTema(kerdesdb, tema));

                foreach (var kerdes in kerdesek)
                {

                    Console.WriteLine(kerdes.KerdesSzoveg);
                    Console.Write("Adja meg a válaszát(igaz/hamis): ");
                    string valasz = Console.ReadLine();
                    if (valasz == "igaz" && kerdes.HelyesValasz == true)
                    {
                        elertpont += kerdes.Pont;
                    }
                    else if (valasz == "hamis" && kerdes.HelyesValasz == false)
                    {
                        elertpont += kerdes.Pont;
                    }
                    Console.Clear();
                    osszpont += kerdes.Pont;
                }
                
                    
            }
            else
            {
                Console.Write("Adja meg a vegyes kérdések számát(max 200): ");
                int kerdesdb = int.Parse(Console.ReadLine());


                Console.WriteLine("A kérdések témái: ");
                foreach (var item in fel.getKerdesTemak())
                {
                    Console.WriteLine(item);
                }
                Console.Write("Adja meg a kérdés témáját(az üres azt jelenti, hogy mindegy)! ");
                string tema = Console.ReadLine();

                List<KomolyKvizApp.Models.Kerdes> kerdesek = new List<KomolyKvizApp.Models.Kerdes>();
                if (tema == "")
                    kerdesek.AddRange(fel.getVegyesKerdes(kerdesdb));
                else
                    kerdesek.AddRange(fel.getVegyesKerdesTema(kerdesdb, tema));
            }
                Console.WriteLine($"Maximális pontszám: {osszpont}\nElért pontszám: {elertpont}");
        }
    }
}
