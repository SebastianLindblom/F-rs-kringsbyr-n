namespace ClassLibrary
{
    public partial class AnsökningensTillval
    {
        public int Id { get; set; }

        public int? AnsökningPrivatId { get; set; }

        public int? TillvalId { get; set; }

        public virtual AnsökningPrivat AnsökningPerson { get; set; }

        public virtual Tillval Tillval { get; set; }
    }
}
