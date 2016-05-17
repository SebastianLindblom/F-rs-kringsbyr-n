namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class GrundbeloppAckvärde
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GrundbeloppAckvärde()
        {
            AnsökningPerson = new HashSet<AnsökningPrivat>();
        }

        [Key]
        public int? Id { get; set; }

        [Required]
        public string typavförsäkring { get; set; }

        [Column("grundbelopp ")]
        [StringLength(50)]
        public string grundbelopp_ { get; set; }

        [Column("år ")]
        [StringLength(50)]
        public string År { get; set; }

        [StringLength(50)]
        public string ackvärde { get; set; }

        [StringLength(50)]
        public string prsFörsäkringsLöpNr_Fk { get; set; }

        [StringLength(50)]
        public string livsförsäkring { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningPrivat> AnsökningPerson { get; set; }
    }
}
