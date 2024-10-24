namespace EffectiveMobile.Domain.Commons
{
    public  class Auditable
    {
        public long Id { get; set; }
        public DateTime CreatedAtt { get; set; }
        public DateTime UpdatedAtt { get; set; }

    }
}
