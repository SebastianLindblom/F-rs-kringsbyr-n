using System.Data.Entity.Migrations;
using System.Data.Entity;
namespace Data.Migrations
{
    using ClassLibrary;
    using System.Linq;
    public class Configuration : DropCreateDatabaseIfModelChanges<DataModel>
    {
        protected override void Seed(DataModel context)
        {
            context.Behörighet.AddOrUpdate(x => x.roll,
                new Behörighet() { roll = "FullAccess", område = "123456789" }
                );

            context.Semesterersättningar.AddOrUpdate(x => x.Id,
               new Semesterersättningar() { Datum = "2015", Semesterersättning = "0.12" }
               );

            context.Provision.AddOrUpdate(x => x.Id,
   new Provision() {  MinAck_värde= "0", MaxAck_värde="1000000", provisionsAndelBarn="0.16",provisionsAndelVuxen="0.18", år= "2015" }
   );

            context.Anställd.AddOrUpdate(x => x.Id,
                new Anställd() { Personnummer = "1990", Förnamn = "Hans", Användarnamn = "vd1", lösenord = "0", roll = "FullAccess" },
                new Anställd() { Personnummer = "1994", Förnamn = "Sebastian", Användarnamn = "sebastian", lösenord = "lindblom", roll = "FullAccess", Postadress = "Göteborg", Agenturnummer = "666", mail = "Sebastian.sverige@hotmail.com", telefonnummer = "+46 76 125 99 36" }


                );

            context.FörsäkringstagarePerson.AddOrUpdate(x=> x.Personnummer,
                new FörsäkringstagarePrivat() {
                    Personnummer = "2010",
                    förnamn = "Jack",
                    efternamn = "Smith",
                    mail ="Jack.Smith@email.com"
            });

            context.GrundbeloppAckvärde.AddOrUpdate(x => x.Id,
                new GrundbeloppAckvärde()
                {
                    typavförsäkring = "Sjuk- och olycksfallsförsäkring för barn (t.o.m. 17 års ålder)",
                    grundbelopp_ = "700000",
                    År = "20150101",
                    ackvärde = "11000",
                });


            context.SaveChanges();
            context.AnsökningPerson.AddOrUpdate(x => x.Löpnummer, new AnsökningPrivat()
            {
                Löpnummer = "1",
                försäkringensNr = "f1",

                ankomstdatum = "20150101",
                betalningsForm = "helår",
                betaldatum = "20150101",
                Tillvalsbelopp = "0",

                GrundbeloppAckvärdesId = context.GrundbeloppAckvärde.Local.FirstOrDefault().Id,
                FörsäkringstagarensPersonnummer = context.FörsäkringstagarePerson.Local.Single(x => x.Personnummer.Equals("2010")).Personnummer,
                AnställdId = context.Anställd.Local.Single(x => x.Personnummer.Equals("1994")).Id
            });

        }
    }
}
