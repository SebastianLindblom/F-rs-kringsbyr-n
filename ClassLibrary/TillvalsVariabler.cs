namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TillvalsVariabler")]
    public partial class TillvalsVariabler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TillvalsVariabler()
        {
            Tillval = new HashSet<Tillval>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Datum { get; set; }

        [StringLength(50)]
        public string Variabeln { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tillval> Tillval { get; set; }
    }
}
