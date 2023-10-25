using System;
using System.Collections.Generic;
using System.Text;

namespace Nepesseg
{
    class Orszag
    {
        public string Nev { get; set; }
        public int Terulet { get; set; }
        public double Nepesseg { get; set; }
        public string Fovaros { get; set; }
        public int FovarosNepesseg { get; set; }

        public Orszag(string sor)
        {
            var darabok = sor.Split(';');
            this.Nev = darabok[0];
            this.Terulet = int.Parse(darabok[1]);
            if (darabok[2].Contains('g'))
            {
                string szam = darabok[2].Replace("g", "0000");
                this.Nepesseg = double.Parse(szam);
            }
            else
                this.Nepesseg = double.Parse(darabok[2]);
            this.Fovaros = darabok[3];
            this.FovarosNepesseg = int.Parse(darabok[4]);
        }

        public int Nepsuruseg()
        {
            return 142;
        }
    }
}
