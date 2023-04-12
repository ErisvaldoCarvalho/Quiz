using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class TestQuestionDAL
    {
        public void Add(TestQuestion _testQuestion, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TestQuestion (IdTest, IdQuestion) VALUES (@IdTest, @IdQuestion)", connection))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (_transaction == null)
                        {
                            connection.Open();
                            transaction = connection.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;
                        cmd.Parameters.AddWithValue("@IdTest", _testQuestion.IdTest);
                        cmd.Parameters.AddWithValue("@IdQuestion", _testQuestion.IdQuestion);
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir uma questão de prova no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public List<TestQuestion> GetAll()
        {
            var testQuestions = new List<TestQuestion>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, IdTest, IdQuestion FROM TestQuestion", connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var testQuestion = new TestQuestion
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        IdTest = Convert.ToInt32(reader["IdTest"]),
                        IdQuestion = Convert.ToInt32(reader["IdQuestion"])
                    };
                    testQuestions.Add(testQuestion);
                }
            }
            return testQuestions;
        }
        public TestQuestion GetById(int _id)
        {
            TestQuestion testQuestion = null;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, IdTest, IdQuestion FROM TestQuestion WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", _id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        testQuestion = new TestQuestion
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            IdTest = Convert.ToInt32(reader["IdTest"]),
                            IdQuestion = Convert.ToInt32(reader["IdQuestion"])
                        };
                    }
                }
                return testQuestion;
            }
        }
        public void Delete(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM TestQuestion WHERE Id = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.Parameters.AddWithValue("@Id", _id);

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir uma questão de prova no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
    }
}