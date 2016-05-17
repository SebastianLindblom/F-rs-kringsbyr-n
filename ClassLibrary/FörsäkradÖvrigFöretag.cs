namespace ClassLibrary
{
    using System.ComponentModel.DataAnnotations;

    public partial class FörsäkradÖvrigFöretag
    {
        public int Id { get; set; }

        public int? ÖvrigAnsökningsId { get; set; }

        [StringLength(50)]
        public string KundensOrganisationsnummer { get; set; }

        public virtual AnsökningÖvrig AnsökningÖvrig { get; set; }

        public virtual FörsäkringstagareFöretag FörsäkringstagareFöretag { get; set; }
    }
}
