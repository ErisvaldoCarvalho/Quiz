using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class QuestionDAL
    {
        public void Add(Question _question, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Questions (Context, Command, ContextImage, IdDiscipline) VALUES (@Context, @Command, @ContextImage, @IdDiscipline)", connection))
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
                        cmd.Parameters.AddWithValue("@Context", _question.Context);
                        cmd.Parameters.AddWithValue("@Command", _question.Command);
                        cmd.Parameters.AddWithValue("@ContextImage", _question.ContextImage ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@IdDiscipline", _question.IdDiscipline);
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir uma questão no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public List<Question> GetAll()
        {
            List<Question> questionList = new List<Question>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Context, Command, ContextImage, IdDiscipline FROM Question", connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var question = new Question
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Context = reader["Context"].ToString(),
                        Command = reader["Command"].ToString(),
                        ContextImage = reader.IsDBNull(reader.GetOrdinal("ContextImage")) ? null : (byte[])reader["ContextImage"],
                        IdDiscipline = Convert.ToInt32(reader["IdDiscipline"]),
                    };
                    questionList.Add(question);
                }
            }
            return questionList;
        }
        public Question GetById(int _id)
        {
            Question question = null;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Context, Command, ContextImage, IdDiscipline FROM Questions WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", _id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        question = new Question
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Context = reader["Context"].ToString(),
                            Command = reader["Command"].ToString(),
                            ContextImage = reader.IsDBNull(reader.GetOrdinal("ContextImage")) ? null : (byte[])reader["ContextImage"],
                            IdDiscipline = Convert.ToInt32(reader["IdDiscipline"]),
                        };
                    }
                }
                return question;
            }
        }
        public void Delete(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Questions WHERE Id = @Id", connection))
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

                        cmd.Parameters.AddWithValue("@Id", _id);

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir a questão do banco de dados.", ex) { Data = { { "Id", _id } } };
                    }
                }
            }
        }
        public void Update(Question _question, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Questions SET Context = @Context, Command = @Command, ContextImage = @ContextImage, IdDiscipline = @IdDiscipline WHERE Id = @Id", connection))
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

                        cmd.Parameters.AddWithValue("@Id", _question.Id);
                        cmd.Parameters.AddWithValue("@Context", _question.Context);
                        cmd.Parameters.AddWithValue("@Command", _question.Command);
                        cmd.Parameters.AddWithValue("@ContextImage", _question.ContextImage ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@IdDiscipline", _question.IdDiscipline);

                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar atualizar a questão no banco de dados.", ex) { Data = { { "Id", _question.Id } } };
                    }
                }
            }
        }
    }
}