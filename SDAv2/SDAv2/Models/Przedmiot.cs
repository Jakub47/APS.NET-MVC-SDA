using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDAv2.Models
{
    public class Przedmiot
    {
        public int PrzedmiotId { get; set; }
        [Required(ErrorMessage = "Wprowadz Nazwe Przedmiotu")]
        public string NazwaPrzedmiotu { get; set; }
        [Required(ErrorMessage = "Wprowadz Semestr")]
        public int Semestr { get; set; }
        [Required(ErrorMessage = "Wprowadz Czy jest Egzaminowany")]
        public bool Egzaminowany { get; set; }
        public int LiczbaGodzinWykladow { get; set; }
        public int LiczbaGodzinCwiczen { get; set; }
        public byte PunktyECTS { get; set; }

    }
}