using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class TestDAL
    {
        public void Add(Test _test, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Tests (Name) VALUES (@Name)", connection))
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
                        cmd.Parameters.AddWithValue("@Name", _test.Name);
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um teste no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }

        public List<Test> GetAll()
        {
            var tests = new List<Test>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Name FROM Tests", connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var test = new Test
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString()
                    };
                    tests.Add(test);
                }
            }
            return tests;
        }

        public Test GetById(int _id)
        {
            Test test = null;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Name FROM Tests WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", _id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        test = new Test
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        };
                    }
                }
                return test;
            }
        }

        public void Delete(int _id, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Tests WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu um erro ao tentar excluir um teste no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public void Update(Test test, SqlTransaction transaction)
        {
            SqlTransaction localTransaction = transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (var cmd = new SqlCommand("UPDATE Tests SET Name = @Name WHERE Id = @Id", connection))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (transaction == null)
                        {
                            connection.Open();
                            localTransaction = connection.BeginTransaction();
                        }

                        cmd.Transaction = localTransaction;
                        cmd.Connection = localTransaction.Connection;

                        cmd.Parameters.AddWithValue("@Name", test.Name);
                        cmd.Parameters.AddWithValue("@Id", test.Id);

                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (transaction == null)
                        {
                            localTransaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (transaction == null)
                        {
                            localTransaction.Rollback();
                        }

                        throw new Exception("Ocorreu um erro ao tentar atualizar o teste no banco de dados.", ex) { Data = { { "Id", test.Id } } };
                    }
                }
            }
        }

    }
}