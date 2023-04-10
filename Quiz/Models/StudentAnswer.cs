using System;

namespace Models
{
    public class StudentAnswer
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdTest { get; set; }
        public int IdQuestion { get; set; }
        public int IdOption { get; set; }
        public DateTime AnsweredOn { get; set; }
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
        public virtual Question Question { get; set; }
        public virtual AnswerOption AnswerOption { get; set; }
    }
}
