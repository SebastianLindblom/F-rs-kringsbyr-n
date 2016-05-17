namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class AnsökningFöretag
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Löpnummer { get; set; }

        [StringLength(50)]
        public string Försäkringsnummer { get; set; }

        [StringLength(50)]
        public string Betalddatum { get; set; }

        [StringLength(50)]
        public string KundensOrganisationsnummer { get; set; }

        [StringLength(50)]
        public string Försäkringsbolag { get; set; }

        [StringLength(50)]
        public string Försäkringstyp { get; set; }

        [StringLength(50)]
        public string Begynnelsedatum { get; set; }

        [StringLength(50)]
        public string förfallodag { get; set; }

        [StringLength(50)]
        public string Betalningsperiod { get; set; }

        [StringLength(50)]
        public string Premie { get; set; }

        public int? AnställdId { get; set; }

        public string Anteckning { get; set; }

        public virtual FörsäkringstagareFöretag FörsäkringstagareFöretag { get; set; }

        public virtual Anställd Personal { get; set; }
    }
}
