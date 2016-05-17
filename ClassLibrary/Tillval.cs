namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tillval")]
    public partial class Tillval
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tillval()
        {
            AnsökningensTillval = new HashSet<AnsökningensTillval>();
        }

        [StringLength(50)]
        public string Typ { get; set; }

        [StringLength(50)]
        public string Belopp { get; set; }

        [StringLength(50)]
        public string Datum { get; set; }

        public int? Id { get; set; }

        public int? VariabelId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsökningensTillval> AnsökningensTillval { get; set; }

        public virtual TillvalsVariabler TillvalsVariabler { get; set; }
    }
}
