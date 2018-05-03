using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDA.Models
{
    public class Ocena
    {
        public int OcenaId { get; set; }
        public int StudentId { get; set; }
        public int PrzedmiotId { get; set; }
        public int OcenaKoncowa { get; set; }
    }
}