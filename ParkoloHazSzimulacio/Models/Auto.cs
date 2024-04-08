using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkoloHazSzimulacio.Models
{
    public class Auto //public azért mert így máshol is elérhető az osztály
    {
        [Key]
        public string Rendszam { get; set; }
    }
}
