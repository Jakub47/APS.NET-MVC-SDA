namespace SDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dormitory",
                c => new
                    {
                        DormitoryId = c.Int(nullable: false, identity: true),
                        Ulica = c.String(),
                        NumerMieszkania = c.String(),
                        Miejscowosc = c.String(),
                        KodPocztowy = c.String(),
                        IloscPokoi = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.DormitoryId);
            
            CreateTable(
                "dbo.Ocena",
                c => new
                    {
                        OcenaId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        PrzedmiotId = c.Int(nullable: false),
                        OcenaKoncowa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OcenaId);
            
            CreateTable(
                "dbo.Przedmiot",
                c => new
                    {
                        PrzedmiotId = c.Int(nullable: false, identity: true),
                        NazwaPrzedmiotu = c.String(nullable: false),
                        Semestr = c.Int(nullable: false),
                        Egzaminowany = c.Boolean(nullable: false),
                        LiczbaGodzinWykladow = c.Int(nullable: false),
                        LiczbaGodzinCwiczen = c.Int(nullable: false),
                        PunktyECTS = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.PrzedmiotId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        DormitoryId = c.Int(nullable: false),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(nullable: false),
                        DataUrodzenia = c.DateTime(nullable: false),
                        Grupa = c.Int(nullable: false),
                        Saldo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
            DropTable("dbo.Przedmiot");
            DropTable("dbo.Ocena");
            DropTable("dbo.Dormitory");
        }
    }
}
