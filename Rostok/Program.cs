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
        }
    }
}
