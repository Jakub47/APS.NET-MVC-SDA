using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SDA.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int DormitoryId { get; set; }
        [Required(ErrorMessage = "Wprowadz Imie")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadz Nazwisko")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadz Date Urodzenia")]
        public DateTime DataUrodzenia { get; set; }
        public int Grupa { get; set; }
        public double Saldo { get; set; }
        public string NazwaPlikuZdjecia { get; set; }

        List<Przedmiot> Przedmioty { get; set; }
    }
}