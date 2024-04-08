using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkoloHazSzimulacio.Models
{
    public class Dij
    {
        [Key]
        public string Rendszam { get; set; }
        [Key]
        public DateTime Vege { get; set; } 
        public int Osszeg { get; set; }
    }
}
