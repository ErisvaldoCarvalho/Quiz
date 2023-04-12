using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class QuestionBLL
    {
        private QuestionDAL questionDAL;
        public QuestionBLL()
        {
            questionDAL = new QuestionDAL();
        }
        public void Add(Question _question)
        {
            if (_question == null)
                throw new ArgumentNullException("A questão não pode ser nula.");

            if (string.IsNullOrWhiteSpace(_question.Context))
                throw new ArgumentException("O contexto da questão não pode estar em branco.");

            if (string.IsNullOrWhiteSpace(_question.Command))
                throw new ArgumentException("O comando da questão não pode estar em branco.");

            questionDAL.Add(_question);
        }
        public List<Question> GetAll()
        {
            return questionDAL.GetAll();
        }
        public Question GetById(int _id)
        {
            if (_id <= 0)
                throw new ArgumentException("O Id da questão não pode ser menor ou igual a zero.");

            return questionDAL.GetById(_id);
        }
        public void Delete(int _id)
        {
            if (_id <= 0)
                throw new ArgumentException("O Id da questão não pode ser menor ou igual a zero.");

            questionDAL.Delete(_id);
        }
        public void Update(Question _question)
        {
            if (_question == null)
                throw new ArgumentNullException("A questão não pode ser nula.");

            if (_question.Id <= 0)
                throw new ArgumentException("O Id da questão não pode ser menor ou igual a zero.");

            if (string.IsNullOrWhiteSpace(_question.Context))
                throw new ArgumentException("O contexto da questão não pode estar em branco.");

            if (string.IsNullOrWhiteSpace(_question.Command))
                throw new ArgumentException("O comando da questão não pode estar em branco.");

            questionDAL.Update(_question);
        }
    }
}