using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentAnswerDAL
    {
        public void Add(StudentAnswer studentAnswer, SqlTransaction transaction = null)
        {
            SqlTransaction trans = transaction;
            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO StudentAnswer 
                                (IdStudent, IdTest, IdQuestion, IdOption, AnsweredOn) 
                                VALUES 
                                (@IdStudent, @IdTest, @IdQuestion, @IdOption, @AnsweredOn)", connection))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdStudent", studentAnswer.IdStudent);
                        cmd.Parameters.AddWithValue("@IdTest", studentAnswer.IdTest);
                        cmd.Parameters.AddWithValue("@IdQuestion", studentAnswer.IdQuestion);
                        cmd.Parameters.AddWithValue("@IdOption", studentAnswer.IdOption);
                        cmd.Parameters.AddWithValue("@AnsweredOn", studentAnswer.AnsweredOn);

                        if (transaction == null)
                        {
                            connection.Open();
                            trans = connection.BeginTransaction();
                        }
                        cmd.Transaction = trans;
                        cmd.Connection = trans.Connection;
                        cmd.ExecuteNonQuery();

                        if (transaction == null)
                            trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir uma resposta de estudante no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public List<StudentAnswer> GetAll()
        {
            var studentAnswers = new List<StudentAnswer>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, IdStudent, IdTest, IdQuestion, IdOption, AnsweredOn FROM StudentAnswer", connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var studentAnswer = new StudentAnswer
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        IdStudent = Convert.ToInt32(reader["IdStudent"]),
                        IdTest = Convert.ToInt32(reader["IdTest"]),
                        IdQuestion = Convert.ToInt32(reader["IdQuestion"]),
                        IdOption = Convert.ToInt32(reader["IdOption"]),
                        AnsweredOn = Convert.ToDateTime(reader["AnsweredOn"])
                    };
                    studentAnswers.Add(studentAnswer);
                }
            }
            return studentAnswers;
        }

        public StudentAnswer GetById(int id)
        {
            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, IdStudent, IdTest, IdQuestion, IdOption, AnsweredOn FROM StudentAnswer WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var studentAnswer = new StudentAnswer
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            IdStudent = Convert.ToInt32(reader["IdStudent"]),
                            IdTest = Convert.ToInt32(reader["IdTest"]),
                            IdQuestion = Convert.ToInt32(reader["IdQuestion"]),
                            IdOption = Convert.ToInt32(reader["IdOption"]),
                            AnsweredOn = Convert.ToDateTime(reader["AnsweredOn"])
                        };

                        return studentAnswer;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public void Delete(int id, SqlTransaction transaction = null)
        {
            SqlTransaction trans = transaction;

            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM StudentAnswer WHERE Id = @Id", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.Text;

                        if (transaction == null)
                        {
                            conn.Open();
                            trans = conn.BeginTransaction();
                        }

                        cmd.Transaction = trans;
                        cmd.Connection = trans.Connection;

                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.ExecuteNonQuery();

                        if (transaction == null)
                        {
                            trans.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir uma resposta de estudante no banco de dados.", ex)
                        {
                            Data = { { "Id", id } }
                        };
                    }
                }
            }
        }

        public void Update(StudentAnswer _studentAnswer, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE StudentAnswer SET IdOption = @IdOption, AnsweredOn = @AnsweredOn WHERE Id = @Id", connection))
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

                        cmd.Parameters.AddWithValue("@IdOption", _studentAnswer.IdOption);
                        cmd.Parameters.AddWithValue("@AnsweredOn", _studentAnswer.AnsweredOn);
                        cmd.Parameters.AddWithValue("@Id", _studentAnswer.Id);

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar atualizar a resposta do aluno no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
    }
}
