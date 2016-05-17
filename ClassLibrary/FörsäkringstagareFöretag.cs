namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FörsäkringstagareFöretag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FörsäkringstagareFöretag()
        {
            AnsökningFöretag = new HashSet<AnsökningFöretag>();
            AnsökningÖvrig = new HashSet<AnsökningÖvrig>();
            FörsäkradÖvrigFöretag = new HashSet<FörsäkradÖvrigFöretag>();
        }

        [Key]
        [StringLength(50)]
        public string Organisationsnummer { get; set; }

        [StringLength(50)]
        public string Företagsnamn { get; set; }

        [StringLength(50)]
        public string ktFörnamn { get; set; }

        [StringLength(50)]
        public string ktEfternamn { get; set; }

        [StringLength(50)]
        public string gatuadress { get; set; }

        [StringLength(50)]
        public string postadress { get; set; }

        [StringLength(50)]
        public string postnummer { get; set; }

        [StringLength(50)]
        public string telefonnummer { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningFöretag> AnsökningFöretag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningÖvrig> AnsökningÖvrig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FörsäkradÖvrigFöretag> FörsäkradÖvrigFöretag { get; set; }
    }
}
