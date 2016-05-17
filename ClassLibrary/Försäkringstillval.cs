namespace ClassLibrary
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Försäkringstillval
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Typ { get; set; }

        [StringLength(50)]
        public string Datum { get; set; }

        [StringLength(50)]
        public string Grundbelopp { get; set; }

        public int? VariabelId { get; set; }

        public virtual Variabler Variabler { get; set; }
    }
}
