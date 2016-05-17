namespace ClassLibrary
{
    using System.ComponentModel.DataAnnotations;

    public partial class FörsäkradÖvrigPrivat
    {
        public int Id { get; set; }

        public int? ÖvrigAnsökningsId { get; set; }

        [StringLength(50)]
        public string KundensPersonnummer { get; set; }

        public virtual AnsökningÖvrig AnsökningÖvrig { get; set; }

        public virtual FörsäkringstagarePrivat FörsäkringstagarePerson { get; set; }
    }
}
