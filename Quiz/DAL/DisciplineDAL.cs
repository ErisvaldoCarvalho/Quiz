using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DisciplineDAL
    {
        public void Add(Discipline _discipline, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Disciplines (Name) VALUES (@Name)", connection))
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
                        cmd.Parameters.AddWithValue("@Name", _discipline.Name);
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir uma disciplina no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public List<Discipline> GetAll()
        {
            var disciplines = new List<Discipline>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Name FROM Discipline", connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var discipline = new Discipline
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString()
                    };
                    disciplines.Add(discipline);
                }
            }
            return disciplines;
        }
        public Discipline GetById(int _id)
        {
            Discipline discipline = null;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Name FROM Discipline WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", _id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        discipline = new Discipline
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        };
                    }
                }
                return discipline;
            }
        }
        public void Delete(int _id, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Discipline WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu um erro ao tentar excluir disciplina no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public void Update(Discipline _discipline, SqlTransaction _transaction)
        {

            SqlTransaction transaction = _transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Discipline SET Name = @Name WHERE Id = @Id", connection))
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

                        cmd.Parameters.AddWithValue("@Name", _discipline.Name);
                        cmd.Parameters.AddWithValue("@Id", _discipline.Id);

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar ação no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
    }
}
