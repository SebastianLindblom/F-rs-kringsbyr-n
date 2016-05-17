namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Semesterersättningar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Semesterersättningar()
        { }

        public int Id { get; set; }

        [StringLength(50)]
        public string Semesterersättning { get; set; }

        [StringLength(50)]
        public string Datum { get; set; }
    }
}
