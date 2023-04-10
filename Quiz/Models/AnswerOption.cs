using System.Collections.Generic;

namespace Models
{
    public class AnswerOption
    {
        public int Id { get; set; }
        public int IdQuestion { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public bool IsCorrect { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
