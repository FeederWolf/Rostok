using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rostok
{
    class Barni
    {
        public string megnevezes { get; set; }
        public string kategoria { get; set; }
        public string egyseg { get; set; }
        public double rost { get; set; }

        public Barni(string sor)
        {
            string[] s = sor.Split(';');

            megnevezes = s[0];
            kategoria = s[1];
            egyseg = s[2];
            rost = double.Parse(s[3]);
        }
    }
}
