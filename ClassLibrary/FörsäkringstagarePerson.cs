namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FörsäkringstagarePrivat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FörsäkringstagarePrivat()
        {
            AnsökningPerson = new HashSet<AnsökningPrivat>();
            AnsökningÖvrig = new HashSet<AnsökningÖvrig>();
            Försäkrad = new HashSet<Försäkrad>();
            FörsäkradÖvrigPrivat = new HashSet<FörsäkradÖvrigPrivat>();
        }

        [Key]
        [StringLength(50)]
        public string Personnummer { get; set; }

        [StringLength(50)]
        public string förnamn { get; set; }

        [StringLength(50)]
        public string efternamn { get; set; }

        [StringLength(50)]
        public string gatuadress { get; set; }

        [StringLength(50)]
        public string postadress { get; set; }

        [StringLength(50)]
        public string postnummer { get; set; }

        [StringLength(50)]
        public string telefonnummerhem { get; set; }

        [StringLength(50)]
        public string telefonnummerarb { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningPrivat> AnsökningPerson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningÖvrig> AnsökningÖvrig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Försäkrad> Försäkrad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FörsäkradÖvrigPrivat> FörsäkradÖvrigPrivat { get; set; }
    }
}
