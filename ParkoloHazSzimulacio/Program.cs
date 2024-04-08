using ParkoloHazSzimulacio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkoloHazSzimulacio
{
    internal class Program
    {
        static Parkolohaz_Szimulacio_Adatbazis adatbazis;
        static void Main(string[] args)
        {
            adatbazis = new Parkolohaz_Szimulacio_Adatbazis();
            adatbazis.Database.EnsureCreated();
            Console.Clear();
            string cim = "Parkolóház szimuláció";
            int poz= (Console.WindowWidth-cim.Length)/2;
            Console.SetCursorPosition(poz, 5);
            Console.WriteLine(cim);
            while (true) { }
        }
    }
}
