using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ParkoloHazSzimulacio.Models
{
    public class Parkolas
    {
        [Key]
        public int Sorszam { get; set; } //get az olvashatóságot a set az írást jelenti
        public string Rendszam { get; set; }
        public DateTime Kezdete { get; set; }
        public DateTime? Vege { get ; set; } // a kérdőjel azért van ott hogy üres maradhat 
    }
}
