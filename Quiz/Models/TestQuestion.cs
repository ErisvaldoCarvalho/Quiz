namespace Models
{
    public class TestQuestion
    {
        public int Id { get; set; }
        public int IdTest { get; set; }
        public int IdQuestion { get; set; }
        public virtual Test Test { get; set; }
        public virtual Question Question { get; set; }
    }
}
