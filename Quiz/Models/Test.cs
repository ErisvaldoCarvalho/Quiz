using System.Collections.Generic;

namespace Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TestQuestion> TestQuestions { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
