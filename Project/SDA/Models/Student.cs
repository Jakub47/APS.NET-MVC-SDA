using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDA.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int DormitoryId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }

    }
}