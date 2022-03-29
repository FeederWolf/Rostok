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
            
        }
    }
}
