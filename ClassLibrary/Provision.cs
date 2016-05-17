namespace ClassLibrary
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Provision")]
    public partial class Provision
    { 
        [Key]
        public int Id { get; set; }

        [Column("totaltMinAck.värde")]
        [StringLength(50)]
        public string MinAck_värde { get; set; }

        [Column("totaltMaxAck.värde")]
        [StringLength(50)]
        public string MaxAck_värde { get; set; }

        [StringLength(50)]
        public string år { get; set; }

        [StringLength(50)]
        public string provisionsAndelBarn { get; set; }

        [StringLength(50)]
        public string provisionsAndelVuxen { get; set; }
    }
}
