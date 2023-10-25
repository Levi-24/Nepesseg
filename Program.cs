using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Nepesseg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> orszagok = new List<Orszag>();
            using StreamReader reader = new StreamReader(
                path: @"..\..\..\src\adatok-utf8.txt",
                Encoding.UTF8);

            _ = reader.ReadLine();
            while (!reader.EndOfStream)
                orszagok.Add(new Orszag(reader.ReadLine()));

            Console.WriteLine($"3.Feladat: {orszagok.Count()}");


        }
    }
}
