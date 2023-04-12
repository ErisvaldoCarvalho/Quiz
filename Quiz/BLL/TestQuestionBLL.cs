using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class TestQuestionBLL
    {
        private TestQuestionDAL testQuestionDAL = new TestQuestionDAL();
        public void Add(TestQuestion testQuestion)
        {
            try
            {
                testQuestionDAL.Add(testQuestion);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma questão de prova no banco de dados.", ex);
            }
        }
        public List<TestQuestion> GetAll()
        {
            try
            {
                return testQuestionDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as questões de prova do banco de dados.", ex);
            }
        }
        public TestQuestion GetById(int id)
        {
            try
            {
                return testQuestionDAL.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao tentar buscar a questão de prova com id {id} do banco de dados.", ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                testQuestionDAL.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao tentar excluir a questão de prova com id {id} do banco de dados.", ex);
            }
        }
    }
}