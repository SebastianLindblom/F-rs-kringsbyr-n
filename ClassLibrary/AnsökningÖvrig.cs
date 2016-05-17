namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AnsökningÖvrig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnsökningÖvrig()
        {
            FörsäkradÖvrigFöretag = new HashSet<FörsäkradÖvrigFöretag>();
            FörsäkradÖvrigPrivat = new HashSet<FörsäkradÖvrigPrivat>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Löpnummer { get; set; }

        [StringLength(50)]
        public string Försäkringsnummer { get; set; }

        [StringLength(50)]
        public string Organisationsnummer { get; set; }

        [StringLength(50)]
        public string FörsäkringstagarensPersonnummer { get; set; }

        [StringLength(50)]
        public string Betalningsform { get; set; }

        [StringLength(50)]
        public string Betaldatum { get; set; }

        [StringLength(50)]
        public string Tabell { get; set; }

        [StringLength(50)]
        public string Premie { get; set; }

        public int? AnställdId { get; set; }

        public virtual FörsäkringstagareFöretag FörsäkringstagareFöretag { get; set; }

        public virtual FörsäkringstagarePrivat FörsäkringstagarePerson { get; set; }

        public virtual Anställd Personal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FörsäkradÖvrigFöretag> FörsäkradÖvrigFöretag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FörsäkradÖvrigPrivat> FörsäkradÖvrigPrivat { get; set; }
    }
}
