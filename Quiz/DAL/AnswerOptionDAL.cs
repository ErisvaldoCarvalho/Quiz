using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class AnswerOptionDAL
    {
        public void Add(AnswerOption _answerOption, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO AnswerOptions (IdQuestion, Description, Image, IsCorrect) VALUES (@IdQuestion, @Description, @Image, @IsCorrect)", connection))
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
                        cmd.Parameters.AddWithValue("@IdQuestion", _answerOption.IdQuestion);
                        cmd.Parameters.AddWithValue("@Description", _answerOption.Description);
                        cmd.Parameters.AddWithValue("@Image", _answerOption.Image ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsCorrect", _answerOption.IsCorrect);
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir uma opção de resposta no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }

        public List<AnswerOption> GetAll()
        {
            var answerOptions = new List<AnswerOption>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, IdQuestion, Description, Image, IsCorrect FROM AnswerOptions", connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var answerOption = new AnswerOption
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        IdQuestion = Convert.ToInt32(reader["IdQuestion"]),
                        Description = reader["Description"].ToString(),
                        Image = reader["Image"] == DBNull.Value ? null : (byte[])reader["Image"],
                        IsCorrect = Convert.ToBoolean(reader["IsCorrect"])
                    };
                    answerOptions.Add(answerOption);
                }
            }
            return answerOptions;
        }

        public AnswerOption GetById(int _id)
        {
            AnswerOption answerOption = null;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, IdQuestion, Description, Image, IsCorrect FROM AnswerOptions WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", _id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        answerOption = new AnswerOption
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            IdQuestion = Convert.ToInt32(reader["IdQuestion"]),
                            Description = reader["Description"].ToString(),
                            Image = reader["Image"] == DBNull.Value ? null : (byte[])reader["Image"],
                            IsCorrect = Convert.ToBoolean(reader["IsCorrect"])
                        };
                    }
                }
                return answerOption;
            }
        }
        public void Delete(int id, SqlTransaction transaction = null)
        {
            SqlTransaction trans = transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (var command = new SqlCommand("DELETE FROM AnswerOption WHERE Id = @Id", connection))
                {
                    try
                    {
                        command.CommandType = System.Data.CommandType.Text;

                        if (transaction == null)
                        {
                            connection.Open();
                            trans = connection.BeginTransaction();
                        }

                        command.Transaction = trans;
                        command.Connection = trans.Connection;
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();

                        if (transaction == null)
                            trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("An error occurred while trying to delete the answer option in the database.", ex) { Data = { { "Id", id } } };
                    }
                }
            }
        }
        public void Update(AnswerOption answerOption, SqlTransaction transaction)
        {
            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (var command = new SqlCommand("UPDATE AnswerOptions SET IdQuestion = @IdQuestion, Description = @Description, Image = @Image, IsCorrect = @IsCorrect WHERE Id = @Id", connection))
                {
                    try
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection = connection;
                        command.Transaction = transaction;

                        command.Parameters.AddWithValue("@IdQuestion", answerOption.IdQuestion);
                        command.Parameters.AddWithValue("@Description", answerOption.Description);
                        command.Parameters.AddWithValue("@Image", answerOption.Image ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@IsCorrect", answerOption.IsCorrect);
                        command.Parameters.AddWithValue("@Id", answerOption.Id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("An error occurred while trying to update the Answer Option in the database.", ex) { Data = { { "Id", answerOption.Id } } };
                    }
                }
            }
        }

    }
}