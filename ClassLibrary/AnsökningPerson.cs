namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class AnsökningPrivat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnsökningPrivat()
        {
            AnsökningensTillval = new HashSet<AnsökningensTillval>();
            Försäkrad = new HashSet<Försäkrad>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Löpnummer { get; set; }

        [StringLength(50)]
        public string försäkringensNr { get; set; }

        [StringLength(50)]
        public string ankomstdatum { get; set; }

        [StringLength(50)]
        public string betalningsForm { get; set; }

        [StringLength(50)]
        public string betaldatum { get; set; }

        public int? GrundbeloppAckvärdesId { get; set; }

        public int? AnställdId{ get; set; }

        [StringLength(50)]
        public string FörsäkringstagarensPersonnummer { get; set; }

        [StringLength(50)]
        public string Variabel { get; set; }

        [StringLength(50)]
        public string Tillvalsbelopp { get; set; }

        public int? LivsförsäkringsId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningensTillval> AnsökningensTillval { get; set; }

        public virtual GrundbeloppAckvärde GrundbeloppAckvärde { get; set; }

        public virtual Anställd Personal { get; set; }

        public virtual FörsäkringstagarePrivat FörsäkringstagarePerson { get; set; }

        public virtual Livsförsäkringar Livsförsäkringar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Försäkrad> Försäkrad { get; set; }
    }
}
