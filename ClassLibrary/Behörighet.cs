namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Behörighet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Behörighet()
        {
            Personal = new HashSet<Anställd>();
        }

        [Key]
        [StringLength(50)]
        public string roll { get; set; }

        [StringLength(50)]
        public string område { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anställd> Personal { get; set; }
    }
}
