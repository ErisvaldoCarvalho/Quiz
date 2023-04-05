using System;
using System.Collections.Generic;

namespace Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

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

    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TestQuestion> TestQuestions { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }

    public class TestQuestion
    {
        public int Id { get; set; }
        public int IdTest { get; set; }
        public int IdQuestion { get; set; }

        public virtual Test Test { get; set; }
        public virtual Question Question { get; set; }
    }

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
