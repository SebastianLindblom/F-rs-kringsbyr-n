using System.Collections.Generic;
using System.Linq;

namespace Service
{
    using ClassLibrary;
    using Business;
    using Business.Calculations;
    using System;

    public class ServiceController
    {
        public ServiceController() { }


        ///<summary>
        ///Save - Add/Edit 
        ///
        ///<para>the Add or Edit is chosen after a query</para>
        ///</summary>

        ///<summary>
        ///Ansökningar
        ///</summary>
        ///
        ///<summary>
        ///Företags ansökningar
        ///</summary>
        ///<param name="a"></param>
        public void Save(AnsökningFöretag a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.FöretagsAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(a.Löpnummer));
                if (entity != null)
                {
                    entity.Löpnummer = a.Löpnummer;
                    entity.Försäkringsnummer = a.Försäkringsnummer;
                    entity.Betalddatum = a.Betalddatum;
                    entity.Försäkringsbolag = a.Försäkringsbolag;
                    entity.Försäkringstyp = a.Försäkringstyp;
                    entity.Begynnelsedatum = a.Begynnelsedatum;
                    entity.förfallodag = a.förfallodag;
                    entity.Betalningsperiod = a.Betalningsperiod;
                    entity.Premie = a.Premie;
                    entity.Anteckning = a.Anteckning;


                    unitOfWork.FöretagsAnsökningar.Edit(entity);

                }
                else unitOfWork.FöretagsAnsökningar.Add(a);
            }
        }
        ///<summary>
        ///Privata Ansökningar
        ///</summary>
        ///<param name="a"></param>
        public void Save(AnsökningPrivat a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.PrivataAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(a.Löpnummer));
                if (entity != null)
                {
                    entity.Löpnummer = a.Löpnummer;
                    entity.försäkringensNr = a.försäkringensNr;
                    entity.ankomstdatum = a.ankomstdatum;
                    entity.betalningsForm = a.betalningsForm;
                    entity.betaldatum = a.betaldatum;
                    entity.Tillvalsbelopp = a.Tillvalsbelopp;

                    if (a.GrundbeloppAckvärdesId != null) entity.GrundbeloppAckvärdesId = a.GrundbeloppAckvärdesId;
                    if (a.FörsäkringstagarensPersonnummer != null) entity.FörsäkringstagarensPersonnummer = a.FörsäkringstagarensPersonnummer;
                    if (a.AnställdId != null) entity.AnställdId = a.AnställdId;


                    unitOfWork.PrivataAnsökningar.Edit(entity);
                }
                else unitOfWork.PrivataAnsökningar.Add(a);
            }
        }
        /// <summary>
        /// Add Ansökningens tillval
        /// </summary>
        /// <param name="a"></param>
        public void Save(AnsökningensTillval a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                unitOfWork.AnsökningensTillval.Add(a);
            }
        }

        ///<summary>
        ///Övriga Ansökningar
        ///</summary>
        ///<param name="a"></param>
        public void Save(AnsökningÖvrig a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.ÖvrigaAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(a.Löpnummer));
                if (entity != null)
                {
                    entity.Löpnummer = a.Löpnummer;
                    entity.Försäkringsnummer = a.Försäkringsnummer;
                    entity.Betalningsform = a.Betalningsform;
                    entity.Tabell = a.Tabell;
                    entity.Premie = a.Premie;
                    entity.Betaldatum = a.Betaldatum;

                    if (a.FörsäkringstagarensPersonnummer != null) entity.FörsäkringstagarensPersonnummer = a.FörsäkringstagarensPersonnummer;
                    else if (a.Organisationsnummer != null) entity.Organisationsnummer = a.Organisationsnummer;
                    if (a.AnställdId != null) entity.AnställdId = a.AnställdId;

                    unitOfWork.ÖvrigaAnsökningar.Edit(entity);
                }
                else unitOfWork.ÖvrigaAnsökningar.Add(a);
            }
        }

        ///<summary>
        ///Försäkringar
        ///</summary>
        ///
        ///<summary>
        ///Grundbelopp och Ackvärde
        ///</summary>
        ///<param name="a"></param>
        public void Save(GrundbeloppAckvärde a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.GrundbeloppAckvärden.SingleOrDefault(x => x.typavförsäkring.Equals(a.typavförsäkring) && x.grundbelopp_.Equals(a.grundbelopp_) && x.ackvärde.Equals(a.ackvärde) && x.År.Equals(a.År));
                if (entity != null)
                {
                    entity.typavförsäkring = a.typavförsäkring;
                    entity.grundbelopp_ = a.grundbelopp_;
                    entity.År = a.År;
                    entity.ackvärde = a.ackvärde;

                    unitOfWork.GrundbeloppAckvärden.Edit(entity);
                }
                else unitOfWork.GrundbeloppAckvärden.Add(a);
            }
        }
        ///<summary>
        ///Livsförsäkringar
        ///</summary>
        ///<param name="a"></param>
        public void Save(Livsförsäkringar a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.Livsförsäkringar.SingleOrDefault(x => x.Typ.Equals(a.Typ) && x.Grundbelopp.Equals(a.Grundbelopp) && x.Datum.Equals(a.Datum));
                if (entity != null)
                {
                    // behöver inte tilldela attributen som redan finns i queryn innan
                    if (a.VariabelId != null) entity.VariabelId = a.VariabelId;

                    unitOfWork.Livsförsäkringar.Edit(entity);
                }
                else unitOfWork.Livsförsäkringar.Add(a);
            }
        }
        ///<summary>
        ///Livsförsäkringsvariabler
        ///</summary>
        ///<param name="a"></param>
        public void Save(Variabler a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.Livsförsäkringsvariabler.SingleOrDefault(x => x.Variabel.Equals(a.Variabel) && x.År.Equals(a.År));
                if (entity != null)
                {
                    entity.Variabel = a.Variabel;
                    entity.År = a.År;

                    unitOfWork.Livsförsäkringsvariabler.Edit(entity);
                }
                else unitOfWork.Livsförsäkringsvariabler.Add(a);
            }
        }
        ///<summary>
        ///Tillvalen
        ///</summary>
        ///<param name="a"></param>
        public void Save(Tillval a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.Tillvalen.SingleOrDefault(x => x.Typ.Equals(a.Typ) && x.Belopp.Equals(a.Belopp) && x.Datum.Equals(a.Datum));
                if (entity != null)
                {
                    entity.Typ = a.Typ;
                    entity.Belopp = a.Belopp;
                    entity.Datum = a.Datum;

                    if (a.VariabelId != null) entity.VariabelId = a.VariabelId;

                    unitOfWork.Tillvalen.Edit(entity);
                }
                else unitOfWork.Tillvalen.Add(a);
            }
        }
        ///<summary>
        ///TillvalsVariabler
        ///</summary>
        ///<param name="a"></param>
        public void Save(TillvalsVariabler a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                if (unitOfWork.Tillvalsvariabler.SingleOrDefault(x => x.Variabeln.Equals(a.Variabeln) && x.Datum.Equals(a.Datum)) != null)
                    unitOfWork.Tillvalsvariabler.Add(a);
            }
        }
        /// <summary>
        /// Save försäkrad for Privat Ansökning
        /// </summary>
        /// <param name="a">Ansöknings Id bestämmer över den försäkrade</param>
        public void Save(Försäkrad a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                if (unitOfWork.Försäkrade.SingleOrDefault(x => x.Id_AnsökningPrivat.Equals(a.Id_AnsökningPrivat)) == null)
                    unitOfWork.Försäkrade.Add(a);
            }
        }


        ///<summary>
        ///Försäkringstagare - Save
        ///</summary>
        ///
        ///<summary>
        ///Företags-försäkringstagare
        ///</summary>
        ///<param name="a"></param>
        public void Save(FörsäkringstagareFöretag a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.FöretagFörsäkringstagarna.SingleOrDefault(x => x.Organisationsnummer.Equals(a.Organisationsnummer));
                if (entity != null)
                {
                    entity.Organisationsnummer = a.Organisationsnummer;
                    entity.Företagsnamn = a.Företagsnamn;
                    entity.ktFörnamn = a.ktFörnamn;
                    entity.ktEfternamn = a.ktEfternamn;
                    entity.gatuadress = a.gatuadress;
                    entity.postadress = a.postadress;
                    entity.postnummer = a.postnummer;
                    entity.telefonnummer = a.telefonnummer;
                    entity.mail = a.mail;
                    entity.fax = a.fax;

                    unitOfWork.FöretagFörsäkringstagarna.Edit(entity);
                }
                else unitOfWork.FöretagFörsäkringstagarna.Add(a);
            }
        }
        ///
        ///<summary>
        ///Privat-försäkringstagare
        ///</summary>
        ///<param name="a"></param>
        public void Save(FörsäkringstagarePrivat a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.PrivatFörsäkringstagarna.SingleOrDefault(x => x.Personnummer.Equals(a.Personnummer));
                if (entity != null)
                {
                    entity.Personnummer = a.Personnummer;
                    entity.förnamn = a.förnamn;
                    entity.efternamn = a.efternamn;
                    entity.gatuadress = a.gatuadress;
                    entity.postadress = a.postadress;
                    entity.postnummer = a.postnummer;
                    entity.telefonnummerhem = a.telefonnummerhem;
                    entity.telefonnummerarb = a.telefonnummerarb;
                    entity.mail = a.mail;

                    unitOfWork.PrivatFörsäkringstagarna.Edit(entity);
                }
                else unitOfWork.PrivatFörsäkringstagarna.Add(a);
            }
        }


        ///<summary>
        ///Personal - Save
        ///</summary>

        /// <summary>
        /// Anställd
        /// </summary>
        /// <param name="a">Personnummret bestämmer över tupeln</param>
        public void Save(Anställd a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.Anställda.SingleOrDefault(x => x.Personnummer.Equals(a.Personnummer));
                if (entity != null)
                {
                    entity.Personnummer = a.Personnummer;
                    entity.Efternamn = a.Efternamn;
                    entity.Förnamn = a.Förnamn;
                    entity.Gatuadress = a.Gatuadress;
                    entity.postnummer = a.postnummer;
                    entity.Postadress = a.Postadress;
                    entity.telefonnummer = a.telefonnummer;
                    entity.mail = a.mail;
                    entity.Agenturnummer = a.Agenturnummer;
                    entity.skattesats = a.skattesats;
                    entity.Användarnamn = a.Användarnamn;
                    entity.lösenord = a.lösenord;

                    unitOfWork.Anställda.Edit(entity);
                }
                else unitOfWork.Anställda.Add(a);
            }
        }


        /// <summary>
        /// Behörighet
        /// </summary>
        /// <param name="a">Roll är PK</param>
        public void Save(Behörighet a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.Behörigheter.SingleOrDefault(x => x.roll.Equals(a.roll));
                if (entity != null)
                {
                    entity.område = a.område;

                    unitOfWork.Behörigheter.Edit(entity);
                }
                else unitOfWork.Behörigheter.Add(a);
            }
        }
        /// <summary>
        /// Provisioner
        /// </summary>
        /// <param name="a">Min och Max tillsammans med År bestämmer över andelarna i databasen</param>
        public void Save(Provision a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.Provisioner.SingleOrDefault(x => x.år.Equals(a.år) && x.MinAck_värde.Equals(a.MinAck_värde) && x.MaxAck_värde.Equals(a.MaxAck_värde));
                if (entity != null)
                {
                    entity.provisionsAndelBarn = a.provisionsAndelBarn;
                    entity.provisionsAndelVuxen = a.provisionsAndelVuxen;
                    entity.MaxAck_värde = a.MaxAck_värde;
                    entity.MinAck_värde = a.MinAck_värde;

                    unitOfWork.Provisioner.Edit(entity);
                }
                else unitOfWork.Provisioner.Add(a);
            }
        }
        /// <summary>
        /// Semesterersättning
        /// </summary>
        /// <param name="a">Ersättningen och datumet tillsammans bestämmmer</param>
        public void Save(Semesterersättningar a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                var entity = unitOfWork.Semesterersättningar.SingleOrDefault(x => x.Semesterersättning.Equals(a.Semesterersättning) && x.Datum.Equals(x.Datum));
                if (entity != null)
                {
                    entity.Datum = a.Datum;
                    entity.Semesterersättning = a.Semesterersättning;

                    unitOfWork.Semesterersättningar.Edit(entity);
                }
                else unitOfWork.Semesterersättningar.Add(a);
            }
        }


        ///<summary>
        ///Get
        ///</summary>

        ///<summary>
        ///Ansökningar
        ///</summary>
        ///
        /// <summary>
        /// Get Företags Ansökning with löpnummer
        /// </summary>
        /// <param name="löpnummer"></param>
        /// <returns></returns>
        public AnsökningFöretag Get_AnsökningFöretag_With_Löpnummer(string löpnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.FöretagsAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(löpnummer));
            }
        }


        /// <summary>
        /// Get Privat Ansökning with löpnummer
        /// </summary>
        /// <param name="löpnummer"></param>
        /// <returns></returns>
        public AnsökningPrivat Get_AnsökningPrivat_With_Löpnummer(string löpnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivataAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(löpnummer));
            }
        }
        public AnsökningensTillval Get_AnsökningensTillval_With_Löpnummer(string löpnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.AnsökningensTillval.SingleOrDefault(x => x.AnsökningPerson.Löpnummer.Equals(löpnummer));
            }
        }

        /// <summary>
        /// Get Övrig Ansökning with löpnummer
        /// </summary>
        /// <param name="löpnummer"></param>
        /// <returns></returns>
        public AnsökningÖvrig Get_AnsökningÖvrig_With_Löpnummer(string löpnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.ÖvrigaAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(löpnummer));
            }
        }
        ///<summary>
        ///Försäkringar
        ///</summary>


        public GrundbeloppAckvärde Get_GrundbeloppAckvärde_With_Id(string id)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.GrundbeloppAckvärden.Get(System.Convert.ToInt32(id));
            }
        }
        public GrundbeloppAckvärde Get_GrundbeloppAckvärde_With_Belopp_Typ_År(string belopp, string typ, string år)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.GrundbeloppAckvärden.SingleOrDefault(x => x.grundbelopp_.Equals(belopp) && x.typavförsäkring.Equals(typ) && x.År.Equals(år));
            }
        }

        public Livsförsäkringar Get_Livsförsäkringar_With_Typ_Datum_Belopp(string typ, string datum, string belopp)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Livsförsäkringar.SingleOrDefault(x => x.Typ.Equals(typ) && x.Datum.Equals(datum) && x.Grundbelopp.Equals(belopp));
            }
        }
        public Variabler Get_LivsförsäkringVariabler_With_Datum_Variabel(string datum, string variabel)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Livsförsäkringsvariabler.SingleOrDefault(x => x.År.Equals(datum) && x.Variabel.Equals(variabel));
            }
        }
        public Tillval Get_Tillval_With_Typ_Datum_Belopp(string typ, string datum, string belopp)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Tillvalen.SingleOrDefault(x => x.Typ.Equals(typ) && x.Datum.Equals(datum) && x.Belopp.Equals(belopp));
            }
        }
        public TillvalsVariabler Get_TillvalsVariabler_With_Datum_Variabel(string datum, string variabel)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Tillvalsvariabler.SingleOrDefault(x => x.Datum.Equals(datum) && x.Variabeln.Equals(variabel));
            }
        }


        ///<summary>
        ///Försäkringstagare
        ///</summary>
        ///
        public FörsäkringstagareFöretag Get_FörsäkringstagareFöretag_With_Organisationsnummer(string organisationsnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.FöretagFörsäkringstagarna.SingleOrDefault(x => x.Organisationsnummer.Equals(organisationsnummer));
            }
        }

        public FörsäkringstagarePrivat Get_FörsäkringstagarePrivat_With_Personnummer(string personnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivatFörsäkringstagarna.SingleOrDefault(x => x.Personnummer.Equals(personnummer));
            }
        }

        public FörsäkringstagarePrivat Get_FörsäkringstagarePrivat_With_Efternamn(string efternamn)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivatFörsäkringstagarna.SingleOrDefault(x => x.efternamn.Equals(efternamn));
            }
        }

        ///<summary>
        ///Personal
        ///</summary>
        ///
        /// <summary>
        /// Gets Anställd with id
        /// </summary>
        /// <param name="personnummer"></param>
        /// <returns> Anställd</returns>
        public Anställd Get_Användare_From_Id(int? id)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Anställda.Get(id);
            }
        }
        /// <summary>
        ///  Gets Anställd with Personnummer
        /// </summary>
        /// <param name="personnummer"></param>
        /// <returns> Anställd</returns>
        public Anställd Get_Anställd_From_Personnummer(string personnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Anställda.Get_Anställd_With_Personnummer(personnummer);
            }
        }
        /// <summary>
        /// Gets Anställd with användarnamn or agenturnummer
        /// </summary>
        /// <param name="användarnamn_agenturnummer"></param>
        /// <returns>Anställd</returns>
        public Anställd Get_Anställd_With_Användarnamn_Agenturnummer(string användarnamn_agenturnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Anställda.SingleOrDefault(x => x.Användarnamn.Equals(användarnamn_agenturnummer) || x.Agenturnummer.Equals(användarnamn_agenturnummer));
            }
        }

        /// <summary>
        ///  Gets Anställd with agenturnummer
        /// </summary>
        /// <param name="agenturnummer"></param>
        /// <returns> Anställd</returns>
        public Anställd Get_Anställd_With_Agenturnummer(string agenturnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Anställda.SingleOrDefault(x => x.Agenturnummer.Equals(agenturnummer));
            }
        }



        public Behörighet Get_Behörighet_With_Id(int? id)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Behörigheter.Get(id);
            }
        }
        public Behörighet Get_Behörighet_With_Id(string id)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Behörigheter.Get(System.Convert.ToInt32(id));
            }
        }

        /// <summary>
        /// Gets Behörighet with roll
        /// </summary>
        /// <param name="roll"></param>
        /// <returns>Behörighet</returns>
        public Behörighet Get_Behörighet_With_Roll(string roll)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Behörigheter.Get_Behörighet_With_Roll(roll);
            }
        }


        public Provision Get_Provisioner_With_Year_Min_Max(string year, string min, string max)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Provisioner.SingleOrDefault(x => x.år.Equals(year) && x.MinAck_värde.Equals(min) && x.MaxAck_värde.Equals(max));
            }
        }
        public Provision Get_Provision_With_Year_Sum(string year, string sum)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Provisioner.SingleOrDefault(x => x.år == year && Tool.decimalMaker(sum) > Tool.decimalMaker(x.MinAck_värde) && Tool.decimalMaker(sum) < Tool.decimalMaker(x.MaxAck_värde));
            }
        }

        /// <summary>
        /// Gets Semesterersättning with ersättning and år
        /// </summary>
        /// <param name="ersättning"></param>
        /// <param name="år"></param>
        /// <returns></returns>
        public Semesterersättningar Get_Semesterersättning_With_Ersättning_Datum(string ersättning, string år)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Semesterersättningar.SingleOrDefault(x => x.Semesterersättning.Equals(ersättning) && x.Datum.Equals(år));
            }
        }


        ///<summary>
        ///Delete
        ///</summary>

        ///<summary>
        ///Ansökningar
        ///</summary>
        public void Remove(AnsökningFöretag s)
        {
            if (s.Löpnummer != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.FöretagsAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(s.Löpnummer));
                    if (a != null)
                    {
                        unitOfWork.FöretagsAnsökningar.Remove(a);
                    }
                }
            }
        }
        public void Remove(AnsökningPrivat s)
        {
            if (s.Löpnummer != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.PrivataAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(s.Löpnummer));
                    if (a != null)
                    {
                        foreach (AnsökningensTillval x in a.AnsökningensTillval) x.AnsökningPrivatId = null;
                        foreach (Försäkrad x in a.Försäkrad) x.Id_AnsökningPrivat = null;

                        unitOfWork.PrivataAnsökningar.Remove(a);
                    }
                }
            }
        }
        public void Remove(AnsökningensTillval a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                unitOfWork.AnsökningensTillval.Remove(a);
            }
        }
        public void Remove(AnsökningÖvrig s)
        {
            if (s.Löpnummer != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.ÖvrigaAnsökningar.SingleOrDefault(x => x.Löpnummer.Equals(s.Löpnummer));
                    if (a != null)
                    {
                        foreach (FörsäkradÖvrigFöretag x in a.FörsäkradÖvrigFöretag) x.ÖvrigAnsökningsId = null;
                        foreach (FörsäkradÖvrigPrivat x in a.FörsäkradÖvrigPrivat) x.ÖvrigAnsökningsId = null;

                        unitOfWork.ÖvrigaAnsökningar.Remove(a);
                    }
                }
            }
        }

        ///<summary>
        ///Försäkringar
        ///</summary>
        public void Remove(GrundbeloppAckvärde s)
        {
            if (s.Id != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.GrundbeloppAckvärden.Get(s.Id);
                    if (a != null)
                    {
                        foreach (AnsökningPrivat x in a.AnsökningPerson)
                        {
                            x.GrundbeloppAckvärdesId = null;
                        }
                        unitOfWork.GrundbeloppAckvärden.Remove(a);
                    }
                }
            }
        }
        public void Remove(Livsförsäkringar s)
        {
            if (s.Id != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.Livsförsäkringar.Get(s.Id);
                    if (a != null)
                    {
                        foreach (AnsökningPrivat x in a.AnsökningPerson) x.LivsförsäkringsId = null;

                        unitOfWork.Livsförsäkringar.Remove(a);
                    }
                }
            }
        }
        public void Remove(Variabler a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                foreach (Försäkringstillval x in a.Försäkringstillval) x.VariabelId = null;
                foreach (Livsförsäkringar x in a.Livsförsäkringar) x.VariabelId = null;

                unitOfWork.Livsförsäkringsvariabler.Remove(a);
            }
        }
        public void Remove(Tillval s)
        {
            if (s.Id != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.Tillvalen.Get(s.Id);
                    if (a != null)
                    {
                        foreach (AnsökningensTillval x in a.AnsökningensTillval) x.TillvalId = null;

                        unitOfWork.Tillvalen.Remove(a);
                    }
                }
            }
        }
        public void Remove(TillvalsVariabler a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                foreach (Tillval x in a.Tillval) x.VariabelId = null;

                unitOfWork.Tillvalsvariabler.Remove(a);
            }
        }


        ///<summary>
        ///Försäkringstagare
        ///</summary>
        public void Remove(FörsäkringstagareFöretag s)
        {
            if (s.Organisationsnummer != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.FöretagFörsäkringstagarna.SingleOrDefault(x => x.Organisationsnummer.Equals(s.Organisationsnummer));
                    if (a != null)
                    {
                        foreach (AnsökningFöretag x in a.AnsökningFöretag) x.KundensOrganisationsnummer = null;
                        foreach (AnsökningÖvrig x in a.AnsökningÖvrig) x.Organisationsnummer = null;
                        foreach (FörsäkradÖvrigFöretag x in a.FörsäkradÖvrigFöretag) x.KundensOrganisationsnummer = null;

                        unitOfWork.FöretagFörsäkringstagarna.Remove(a);
                    }
                }
            }
        }
        public void Remove(FörsäkringstagarePrivat s)
        {
            if (s.Personnummer != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.PrivatFörsäkringstagarna.SingleOrDefault(x => x.Personnummer.Equals(s.Personnummer));
                    if (a != null)
                    {
                        foreach (AnsökningPrivat x in a.AnsökningPerson) x.FörsäkringstagarensPersonnummer = null;
                        foreach (Försäkrad x in a.Försäkrad) x.KundPersonnummer = null;
                        foreach (AnsökningÖvrig x in a.AnsökningÖvrig) x.FörsäkringstagarensPersonnummer = null;
                        foreach (FörsäkradÖvrigPrivat x in a.FörsäkradÖvrigPrivat) x.KundensPersonnummer = null;

                        unitOfWork.PrivatFörsäkringstagarna.Remove(a);
                    }
                }
            }
        }


        ///<summary>
        ///Personal
        ///</summary>
        ///
        /// <summary>
        /// Remove anställd with personnummer
        /// </summary>
        /// <param name="personnummer"></param>
        /// <returns>void</returns>
        public void Remove(Anställd s)
        {
            if (s.Personnummer != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.Anställda.SingleOrDefault(x => x.Personnummer.Equals(s.Personnummer));
                    if (a != null)
                    {
                        foreach (AnsökningFöretag x in a.AnsökningFöretag) x.AnställdId = null;
                        foreach (AnsökningPrivat x in a.AnsökningPrivat) x.AnställdId = null;
                        foreach (AnsökningÖvrig x in a.AnsökningÖvrig) x.AnställdId = null;

                        unitOfWork.Anställda.Remove(a);
                    }
                }
            }
        }
        public void Remove(Behörighet s)
        {
            if (s.roll != null)
            {
                using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
                {
                    var a = unitOfWork.Behörigheter.SingleOrDefault(x => x.roll.Equals(s.roll));
                    if (a != null)
                    {
                        foreach (Anställd x in a.Personal) x.roll = null;

                        unitOfWork.Behörigheter.Remove(a);
                    }
                }
            }
        }
        public void Remove(Provision a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                unitOfWork.Provisioner.Remove(a);
            }
        }
        public void Remove(Semesterersättningar a)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                unitOfWork.Semesterersättningar.Remove(a);
            }
        }

        ///<summary>
        ///List
        ///</summary>

        ///<summary>
        ///Ansökningar
        ///</summary>

        ///Företag
        public IEnumerable<AnsökningFöretag> Get_AnsökningFöretag_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.FöretagsAnsökningar.GetAll().ToList();
            }
        }
        public IEnumerable<AnsökningFöretag> Get_AnsökningFöretag_With_Företagsnamn(string företagsnamn)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.FöretagsAnsökningar.Find(x => x.FörsäkringstagareFöretag.Företagsnamn.Contains(företagsnamn)).ToList();
            }
        }
        public IEnumerable<AnsökningFöretag> Get_AnsökningFöretag_With_Organisationnummer(string organisationsnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.FöretagFörsäkringstagarna.Find(x => x.Organisationsnummer.Contains(organisationsnummer)).SelectMany(x => x.AnsökningFöretag).ToList();
                //TODO: testa query
                //return unitOfWork.FöretagsAnsökningar.GetWith_Organisationsnummer(organisationsnummer).ToList();
            }
        }

        ///Privat
        public IEnumerable<AnsökningPrivat> Get_AnsökningPrivat_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivataAnsökningar.GetAll().ToList();
            }
        }
        /// <summary>
        /// Get Privata Ansökningar with försäkringstagarens efternamn
        /// </summary>
        /// <param name="efternamn"></param>
        /// <returns></returns>
        public IEnumerable<AnsökningPrivat> Get_AnsökningPrivat_With_FörsäkringstagarensEfternamn(string efternamn)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivatFörsäkringstagarna.Find(x => x.efternamn.Contains(efternamn)).SelectMany(x => x.AnsökningPerson).ToList();
                // TODO: testa query 
                //return unitOfWork.PrivataAnsökningar.Find(x => x.FörsäkringstagarePerson.efternamn.Contains(efternamn)).ToList();
            }
        }
        /// <summary>
        /// Get Privata Ansökningar with Försäkrades efternamn
        /// </summary>
        /// <param name="efternamn"></param>
        /// <returns>List of Privat Ansökning</returns>
        public IEnumerable<AnsökningPrivat> Get_AnsökningPrivat_With_FörsäkradesEfternamn(string efternamn)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Försäkrade.Find(x => x.FörsäkringstagarePerson.efternamn.Contains(efternamn)).Select(x => x.AnsökningPerson).ToList();
            }
        }
        public IEnumerable<AnsökningPrivat> Get_AnsökningPrivat_With_FörsäkringstagarensPersonnummer(string personnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivataAnsökningar.GetWith_FörsäkringstagarensPersonnummer(personnummer).ToList();
            }
        }
        public IEnumerable<AnsökningPrivat> Get_AnsökningPrivat_FörsäkradesEfternamn(string efternamn)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivataAnsökningar.GetWith_FörsäkradesEfternamn(efternamn).ToList();
            }
        }
        public IEnumerable<AnsökningPrivat> Get_AnsökningPrivat_FörsäkradesFörnamn(string förnamn)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivataAnsökningar.GetWith_FörsäkradesFörnamn(förnamn).ToList();
            }
        }
        public IEnumerable<AnsökningPrivat> Get_AnsökningPrivat_FörsäkradesPersonnummer(string personnummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivataAnsökningar.GetWith_FörsäkradesPersonnummer(personnummer).ToList();
            }
        }
        //Ansökningenstillval

        public AnsökningensTillval Get_AnsökningensTillval_With_Id(int? id)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.AnsökningensTillval.Get(id);
            }
        }


        ///Övrig    
        ///
        public IEnumerable<AnsökningÖvrig> Get_AnsökningÖvrig_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.ÖvrigaAnsökningar.GetAll();
            }
        }
        public IEnumerable<AnsökningÖvrig> Get_AnsökningÖvrig_Försäkringstagarensefternamn(string efternamn_Företagsnamn)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.ÖvrigaAnsökningar.GetWith_Försäkringstagarensefternamn(efternamn_Företagsnamn).ToList();
            }
        }
        public IEnumerable<AnsökningÖvrig> GetAnsökningÖvrig_FörsäkringstagarensPersonnummer(string person_Organisations_nummer)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.ÖvrigaAnsökningar.GetWith_Person_Organisations_nummer(person_Organisations_nummer).ToList();
            }
        }

        ///<summary>
        ///Försäkringar
        ///</summary>

        public IEnumerable<GrundbeloppAckvärde> Get_GrundbeloppAckvärde_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.GrundbeloppAckvärden.GetAll();
            }
        }
        public IEnumerable<GrundbeloppAckvärde> Get_GrundbeloppAckvärde_With_År(string år)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.GrundbeloppAckvärden.Find(x => x.År.Contains(år));
            }
        }
        public IEnumerable<GrundbeloppAckvärde> Get_GrundbeloppAckvärde_With_År_Typ(string år, string typ)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.GrundbeloppAckvärden.Find(x => x.År.Contains(år) && x.typavförsäkring.Equals(typ));
            }
        }
        public GrundbeloppAckvärde Get_GrundbeloppAckvärde_With_Belopp_Typ(string belopp, string typ)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.GrundbeloppAckvärden.SingleOrDefault(x => x.grundbelopp_.Equals(belopp) && x.typavförsäkring.Equals(typ));
            }
        }
        public IEnumerable<Livsförsäkringar> Get_Livsförsäkringar_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Livsförsäkringar.GetAll();
            }
        }
        public IEnumerable<Livsförsäkringar> Get_Livsförsäkringar_With_Datum(string datum)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Livsförsäkringar.Find(x => x.Datum.Equals(datum));
            }
        }
        public IEnumerable<Variabler> Get_LivsförsäkringVariabler_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Livsförsäkringsvariabler.GetAll();
            }
        }
        public IEnumerable<Tillval> Get_Tillval_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Tillvalen.GetAll();
            }
        }
        public IEnumerable<Tillval> Get_Tillval_With_Datum(string yyyy)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Tillvalen.Find(x => x.Datum.Contains(yyyy));
            }
        }
        public IEnumerable<TillvalsVariabler> Get_TillvalsVariabler_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Tillvalsvariabler.GetAll();
            }
        }

        ///<summary>
        ///Försäkringstagare
        ///</summary>

        public IEnumerable<FörsäkringstagareFöretag> Get_FörsäkringstagareFöretag_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.FöretagFörsäkringstagarna.GetAll();
            }
        }
        public IEnumerable<FörsäkringstagarePrivat> Get_FörsäkringstagarePrivat_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.PrivatFörsäkringstagarna.GetAll();
            }
        }

        ///<summary>
        ///Personal
        ///</summary>
        public IEnumerable<Anställd> Get_Anställd_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Anställda.GetAll();
            }
        }
        public IEnumerable<Behörighet> Get_Behörigheter_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Behörigheter.GetAll();
            }
        }
        public IEnumerable<Provision> Get_Provisioner_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Provisioner.GetAll();
            }
        }
        public IEnumerable<Provision> Get_Provisioner_With_Year(string year)
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Provisioner.Find(x => x.år.Equals(year));
            }
        }

        public IEnumerable<Semesterersättningar> Get_Semesterersättningar_GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                return unitOfWork.Semesterersättningar.GetAll();
            }
        }



        ///<summary>
        ///Calculations
        ///</summary>
        ///

        public string[] Get_MonthlyCommision(string användarnamn, string år, string månad)
        {
            return MonthlyCommission.beräknaProvision(användarnamn, år, månad);
        }
        public void Export_MonthlyCommision(string Förnamn, string Efternamn, string Gatuadress, string Postadress, string SemesterersättningProv, string BuAckvärde, string VuAckvärde, string LivAckvärde, string ProvÖvrigt, string ProvSo, string ProvLiv, string SummaAckvärde, string SumSemesterers, string SummaProv, string PrelSkattProv, string AvgårSkatt, string InsättningBank, string AttBetala)
        {
            Buisness.Integration.Printer.Utskrift.ExporteraProvisionTillUtskrift(Förnamn, Efternamn, Gatuadress, Postadress, SemesterersättningProv, BuAckvärde, VuAckvärde, LivAckvärde, ProvÖvrigt, ProvSo, ProvLiv, SummaAckvärde, SumSemesterers, SummaProv, PrelSkattProv, AvgårSkatt, InsättningBank, AttBetala);
        }
        public string[] Get_MonthlySales(string användarnamn, string år, string månad)
        {
            return MonthlySales.beräknaMånadsförsäljning(användarnamn, år, månad);
        }
        public void Export_YearlyReport(string år)
        {
            YearlyReport.YearStatistics(år);
        }
        public void Export_Prospect()
        {
            Buisness.Integration.Printer.Utskrift.SkrivUtProspekt(Prospekt.Prospekter());
        }

        ///<summary>
        ///Utility
        ///</summary>
        ///
        public string[] DateSq(string date)
        {
            return Tool.DateSeq(date);
        }



    }
}
