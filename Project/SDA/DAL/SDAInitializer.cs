using SDA.Migrations;
using SDA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SDA.DAL
{
    public class SDAInitializer : MigrateDatabaseToLatestVersion<SDAContext,Configuration>
    {
        public static void SeedKursyData(SDAContext context)
        {
            var przedmioty = new List<Przedmiot>
            {
                new Przedmiot { NazwaPrzedmiotu = "Programowanie",Semestr = 1,Egzaminowany = false,LiczbaGodzinWykladow = 56,
                LiczbaGodzinCwiczen = 56,PunktyECTS = 8},
                new Przedmiot { NazwaPrzedmiotu = "Prawo",Semestr = 2,Egzaminowany = true,LiczbaGodzinWykladow = 28,
                LiczbaGodzinCwiczen = 10,PunktyECTS = 2},
                new Przedmiot { NazwaPrzedmiotu = "Architektura Systemow komputerowych",Semestr = 4,Egzaminowany = true,LiczbaGodzinWykladow = 28,
                LiczbaGodzinCwiczen = 40,PunktyECTS = 6},
                new Przedmiot { NazwaPrzedmiotu = "Uklady Cyfrowe",Semestr = 2,Egzaminowany = false,LiczbaGodzinWykladow = 24,
                LiczbaGodzinCwiczen = 18,PunktyECTS = 6},
                new Przedmiot { NazwaPrzedmiotu = "Fizyka",Semestr = 1,Egzaminowany = true,LiczbaGodzinWykladow = 24,
                LiczbaGodzinCwiczen = 23,PunktyECTS = 8},
            };

            przedmioty.ForEach(i => context.Przedmiot.AddOrUpdate(i));
            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            

            var dormitorys = new List<Dormitory>
            {
                new Dormitory {Ulica = "Grzybowskiego",NumerMieszkania = "2",Miejscowosc = "Gdynia",KodPocztowy = "88-444",
                IloscPokoi = 132},
                new Dormitory {Ulica = "Grzybowskiego",NumerMieszkania = "1",Miejscowosc = "Gdynia",KodPocztowy = "88-443",
                IloscPokoi = 92},
                new Dormitory {Ulica = "Sloneczna",NumerMieszkania = "3",Miejscowosc = "Gdansk",KodPocztowy = "33-221",
                IloscPokoi = 210},
            };

            dormitorys.ForEach(i => context.Dormitory.AddOrUpdate(i));
            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            var studenci = new List<Student>
            {
                new Student{DormitoryId = 1,Imie = "Jakub",Nazwisko = "Kowalski",DataUrodzenia = new DateTime(1996,6,15),Grupa=165,
                Saldo = 0},
                new Student{DormitoryId = 1,Imie = "Jan",Nazwisko = "Poznanki",DataUrodzenia = new DateTime(1996,2,13),Grupa=172,
                Saldo = 0},
                new Student{DormitoryId = 2,Imie = "Anna",Nazwisko = "Tomaszow",DataUrodzenia = new DateTime(1997,5,7),Grupa=165,
                Saldo = 0},
                new Student{DormitoryId = 3,Imie = "Katarzyna",Nazwisko = "Gnet",DataUrodzenia = new DateTime(1995,2,20),Grupa=134,
                Saldo = 0},
                new Student{DormitoryId = 3,Imie = "Mateusz",Nazwisko = "Kowal",DataUrodzenia = new DateTime(1995,10,19),Grupa=133,
                Saldo = 0},
            };

            studenci.ForEach(i => context.Student.AddOrUpdate(i));
            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
    }
}