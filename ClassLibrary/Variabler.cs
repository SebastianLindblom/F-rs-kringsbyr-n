namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Variabler")]
    public partial class Variabler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Variabler()
        {
            Försäkringstillval = new HashSet<Försäkringstillval>();
            Livsförsäkringar = new HashSet<Livsförsäkringar>();
        }

        public int Id { get; set; }

        [StringLength(10)]
        public string År { get; set; }

        [StringLength(10)]
        public string Variabel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Försäkringstillval> Försäkringstillval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livsförsäkringar> Livsförsäkringar { get; set; }
    }
}
