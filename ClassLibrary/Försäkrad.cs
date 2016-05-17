namespace ClassLibrary
{
    using System.ComponentModel.DataAnnotations;

    public partial class Försäkrad
    {
        public int Id { get; set; }

        public int? Id_AnsökningPrivat { get; set; }

        [Required]
        [StringLength(50)]
        public string KundPersonnummer { get; set; }

        public virtual AnsökningPrivat AnsökningPerson { get; set; }

        public virtual FörsäkringstagarePrivat FörsäkringstagarePerson { get; set; }
    }
}
