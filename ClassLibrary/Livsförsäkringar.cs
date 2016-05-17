namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Livsförsäkringar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livsförsäkringar()
        {
            AnsökningPerson = new HashSet<AnsökningPrivat>();
        }

        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Typ { get; set; }

        [StringLength(50)]
        public string Datum { get; set; }

        [StringLength(50)]
        public string Grundbelopp { get; set; }

        public int? VariabelId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningPrivat> AnsökningPerson { get; set; }

        public virtual Variabler Variabler { get; set; }
    }
}
