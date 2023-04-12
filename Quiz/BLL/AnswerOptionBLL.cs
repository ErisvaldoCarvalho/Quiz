using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL;
using Models;

namespace BLL
{
    public class AnswerOptionBLL
    {
        private AnswerOptionDAL answerOptionDAL;
        public AnswerOptionBLL()
        {
            answerOptionDAL = new AnswerOptionDAL();
        }
        public void Add(AnswerOption answerOption)
        {
            try
            {
                answerOptionDAL.Add(answerOption);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AnswerOption> GetAll()
        {
            try
            {
                return answerOptionDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AnswerOption GetById(int id)
        {
            try
            {
                return answerOptionDAL.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int id)
        {
            try
            {
                answerOptionDAL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(AnswerOption answerOption)
        {
            try
            {
                answerOptionDAL.Update(answerOption);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}