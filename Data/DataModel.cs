
namespace Data
{
    using System;
    using System.Data.Entity;
    using ClassLibrary;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
            Database.SetInitializer<DataModel>(new Migrations.Configuration());
        }

        public virtual DbSet<AnsökningensTillval> AnsökningensTillval { get; set; }
        public virtual DbSet<AnsökningFöretag> AnsökningFöretag { get; set; }
        public virtual DbSet<AnsökningPrivat> AnsökningPerson { get; set; }
        public virtual DbSet<AnsökningÖvrig> AnsökningÖvrig { get; set; }
        public virtual DbSet<Behörighet> Behörighet { get; set; }
        public virtual DbSet<Försäkrad> Försäkrad { get; set; }
        public virtual DbSet<FörsäkradÖvrigFöretag> FörsäkradÖvrigFöretag { get; set; }
        public virtual DbSet<FörsäkradÖvrigPrivat> FörsäkradÖvrigPrivat { get; set; }
        public virtual DbSet<FörsäkringstagareFöretag> FörsäkringstagareFöretag { get; set; }
        public virtual DbSet<FörsäkringstagarePrivat> FörsäkringstagarePerson { get; set; }
        public virtual DbSet<Försäkringstillval> Försäkringstillval { get; set; }
        public virtual DbSet<GrundbeloppAckvärde> GrundbeloppAckvärde { get; set; }
        public virtual DbSet<Livsförsäkringar> Livsförsäkringar { get; set; }
        public virtual DbSet<Anställd> Anställd { get; set; }
        public virtual DbSet<Provision> Provision { get; set; }
        public virtual DbSet<Semesterersättningar> Semesterersättningar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tillval> Tillval { get; set; }
        public virtual DbSet<TillvalsVariabler> TillvalsVariabler { get; set; }
        public virtual DbSet<Variabler> Variabler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnsökningPrivat>()
                .HasMany(e => e.AnsökningensTillval)
                .WithOptional(e => e.AnsökningPerson)
                .HasForeignKey(e => e.AnsökningPrivatId);
            

            modelBuilder.Entity<AnsökningPrivat>()
                .HasMany(e => e.Försäkrad)
                .WithRequired(e => e.AnsökningPerson)
                .HasForeignKey(e => e.Id_AnsökningPrivat)
                .WillCascadeOnDelete(true);


            modelBuilder.Entity<AnsökningÖvrig>()
                .HasMany(e => e.FörsäkradÖvrigFöretag)
                .WithOptional(e => e.AnsökningÖvrig)
                .HasForeignKey(e => e.ÖvrigAnsökningsId);

            modelBuilder.Entity<AnsökningÖvrig>()
                .HasMany(e => e.FörsäkradÖvrigPrivat)
                .WithOptional(e => e.AnsökningÖvrig)
                .HasForeignKey(e => e.ÖvrigAnsökningsId);

            modelBuilder.Entity<FörsäkringstagareFöretag>()
                .HasMany(e => e.AnsökningFöretag)
                .WithOptional(e => e.FörsäkringstagareFöretag)
                .HasForeignKey(e => e.KundensOrganisationsnummer);

            modelBuilder.Entity<FörsäkringstagareFöretag>()
                .HasMany(e => e.AnsökningÖvrig)
                .WithOptional(e => e.FörsäkringstagareFöretag)
                .HasForeignKey(e => e.Organisationsnummer);

            modelBuilder.Entity<FörsäkringstagareFöretag>()
                .HasMany(e => e.FörsäkradÖvrigFöretag)
                .WithOptional(e => e.FörsäkringstagareFöretag)
                .HasForeignKey(e => e.KundensOrganisationsnummer);

            modelBuilder.Entity<FörsäkringstagarePrivat>()
                .HasMany(e => e.AnsökningPerson)
                .WithOptional(e => e.FörsäkringstagarePerson)
                .HasForeignKey(e => e.FörsäkringstagarensPersonnummer);

            modelBuilder.Entity<FörsäkringstagarePrivat>()
                .HasMany(e => e.AnsökningÖvrig)
                .WithOptional(e => e.FörsäkringstagarePerson)
                .HasForeignKey(e => e.FörsäkringstagarensPersonnummer);

            modelBuilder.Entity<FörsäkringstagarePrivat>()
                .HasMany(e => e.Försäkrad)
                .WithRequired(e => e.FörsäkringstagarePerson)
                .HasForeignKey(e => e.KundPersonnummer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FörsäkringstagarePrivat>()
                .HasMany(e => e.FörsäkradÖvrigPrivat)
                .WithOptional(e => e.FörsäkringstagarePerson)
                .HasForeignKey(e => e.KundensPersonnummer);

            modelBuilder.Entity<GrundbeloppAckvärde>()
                .HasMany(e => e.AnsökningPerson)
                .WithOptional(e => e.GrundbeloppAckvärde)
                .HasForeignKey(e => e.GrundbeloppAckvärdesId);



            modelBuilder.Entity<Livsförsäkringar>()
                .HasMany(e => e.AnsökningPerson)
                .WithOptional(e => e.Livsförsäkringar)
                .HasForeignKey(e => e.LivsförsäkringsId);
            

            modelBuilder.Entity<Anställd>()
                .HasMany(e => e.AnsökningFöretag)
                .WithOptional(e => e.Personal)
                .HasForeignKey(e => e.AnställdId);

            modelBuilder.Entity<Anställd>()
                .HasMany(e => e.AnsökningPrivat)
                .WithOptional(e => e.Personal)
                .HasForeignKey(e => e.AnställdId);

            modelBuilder.Entity<Anställd>()
                .HasMany(e => e.AnsökningÖvrig)
                .WithOptional(e => e.Personal)
                .HasForeignKey(e => e.AnställdId);


            modelBuilder.Entity<TillvalsVariabler>()
                .HasMany(e => e.Tillval)
                .WithOptional(e => e.TillvalsVariabler)
                .HasForeignKey(e => e.VariabelId);

            modelBuilder.Entity<Variabler>()
                .Property(e => e.År)
                .IsFixedLength();

            modelBuilder.Entity<Variabler>()
                .Property(e => e.Variabel)
                .IsFixedLength();

            modelBuilder.Entity<Variabler>()
                .HasMany(e => e.Försäkringstillval)
                .WithOptional(e => e.Variabler)
                .HasForeignKey(e => e.VariabelId)
            .WillCascadeOnDelete();

            modelBuilder.Entity<Variabler>()
                .HasMany(e => e.Livsförsäkringar)
                .WithOptional(e => e.Variabler)
                .HasForeignKey(e => e.VariabelId)
            .WillCascadeOnDelete();
        }
    }
}
