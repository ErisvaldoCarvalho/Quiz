using System.Collections.Generic;

namespace Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public string Command { get; set; }
        public byte[] ContextImage { get; set; }
        public int IdDiscipline { get; set; }

        public virtual Discipline Discipline { get; set; }
        public virtual ICollection<AnswerOption> AnswerOptions { get; set; }
    }
}
