namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("Personal")]
    public partial class Anställd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anställd()
        {
            AnsökningFöretag = new HashSet<AnsökningFöretag>();
            AnsökningPrivat = new HashSet<AnsökningPrivat>();
            AnsökningÖvrig = new HashSet<AnsökningÖvrig>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Personnummer { get; set; }

        [StringLength(50)]
        public string Förnamn { get; set; }

        [StringLength(50)]
        public string Efternamn { get; set; }

        [StringLength(50)]
        public string Gatuadress { get; set; }

        [StringLength(50)]
        public string Postadress { get; set; }

        [StringLength(50)]
        public string postnummer { get; set; }

        [StringLength(50)]
        public string telefonnummer { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [StringLength(50)]
        public string Användarnamn { get; set; }

        [StringLength(50)]
        public string lösenord { get; set; }

        [StringLength(50)]
        public string Agenturnummer { get; set; }

        [StringLength(50)]
        public string skattesats { get; set; }

        [StringLength(50)]
        public string roll { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningFöretag> AnsökningFöretag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningPrivat> AnsökningPrivat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningÖvrig> AnsökningÖvrig { get; set; }

        public virtual Behörighet Behörighet { get; set; }

        public virtual Semesterersättningar Semesterersättningar { get; set; }

       
    }
}
