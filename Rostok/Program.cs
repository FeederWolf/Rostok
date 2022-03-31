using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rostok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Barni> lista = new List<Barni>();
            foreach (var i in File.ReadAllLines("rostok.txt").Skip(1))
            {
                lista.Add(new Barni(i));
            }
            Console.WriteLine($"3. feladat: Élelmiszerek száma: {lista.Count}");


            int marcimegorult = 0;
            
            foreach (var i in lista)
            {
                if (i.egyseg != "100g")
                {
                    marcimegorult++;
                }
            }
            Console.WriteLine($"4. feladat: Nem 100g-os egység: {marcimegorult}");

            marcimegorult = 0;
            double rosttartalom = 0;
            foreach (var i in lista)
            {
                if (i.egyseg == "100g" && i.kategoria == "Friss gyümölcsök")
                {
                    marcimegorult++;
                    rosttartalom += i.rost;
                }
            }
            Console.WriteLine($"5. feladat: Friss gyümölcsök átlagos rosttartalma: {rosttartalom / marcimegorult}g");

            
            string beker = "";

            do
            {
                Console.Write("6. feladat: Kérek egy karakterláncot: ");
                beker = Console.ReadLine();
            } while (beker.Length < 2);



            Console.WriteLine($"7. feladat: Kategóriák száma: { lista.GroupBy(x => x.kategoria).Count() }");

            int aszalt = 0;
            int friss = 0;
            int gab = 0;
            int zöld = 0;
            int mag = 0;

            foreach (var i in lista)
            {
                if (i.kategoria == "Aszalt gyümölcsök")
                {
                    aszalt++;
                }
                if (i.kategoria == "Friss gyümölcsök")
                {
                    friss++;
                }
                if (i.kategoria == "Gabonák és lisztek")
                {
                    gab++;
                }
                if (i.kategoria == "Zöldségek")
                {
                    zöld++;
                }
                if (i.kategoria == "Magvak")
                {
                    mag++;
                }
            }
            Console.WriteLine("8. feladat: Statisztika");
            Console.WriteLine($"\t Aszalt gyümölcsök - {aszalt}");
            Console.WriteLine($"\t Friss gyümölcsök - {friss}");
            Console.WriteLine($"\t Gabonák és lisztek - {gab}");
            Console.WriteLine($"\t Zöldségek - {zöld}");
            Console.WriteLine($"\t Magvak - {mag}");



            Console.WriteLine("9. feladat: Rostok100g.txt");
            StreamWriter kiirat = File.CreateText("Rostok100g.txt"); //create file
            kiirat.Close(); //STOP soros 0/0/0
            List<string> lista2 = new List<string>(); //lista
            lista2.Add("Megnevezés;Kategória;Rost;"); //+ bullshit

            foreach (var i in lista)
            {
                if (i.egyseg == "100g")
                {
                    lista2.Add($"{i.megnevezes};{i.kategoria};{i.rost}"); //egyértelmű
                }
            }
            File.WriteAllLines("Rostok100g.txt", lista2);
        }
    }
}
