using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL
    {
        public void Add(Student student, SqlTransaction transaction = null)
        {
            SqlTransaction localTransaction = transaction;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Students (Name, Email) VALUES (@Name, @Email)", connection))
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
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Email", student.Email);
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        if (transaction == null)
                            localTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        localTransaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um estudante no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public List<Student> GetAll()
        {
            var students = new List<Student>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Name, Email FROM Students", connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var student = new Student
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString()
                    };
                    students.Add(student);
                }
            }
            return students;
        }
        public Student GetById(int id)
        {
            Student student = null;

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT Id, Name, Email FROM Students WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student = new Student
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }
                }
                return student;
            }
        }
        public void Delete(int id, SqlTransaction transaction = null)
        {
            SqlTransaction localTransaction = transaction;

            using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE Id = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (transaction == null)
                        {
                            cn.Open();
                            localTransaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = localTransaction;
                        cmd.Connection = localTransaction.Connection;

                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.ExecuteNonQuery();

                        if (transaction == null)
                            localTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        localTransaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir um estudante do banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public void Update(Student student, SqlTransaction transaction = null)
        {
            SqlTransaction internalTransaction = transaction;

            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("UPDATE Students SET Name = @Name, Email = @Email WHERE Id = @Id", connection))
                {
                    try
                    {
                        command.CommandType = System.Data.CommandType.Text;

                        if (transaction == null)
                        {
                            connection.Open();
                            internalTransaction = connection.BeginTransaction();
                        }

                        command.Transaction = internalTransaction;
                        command.Connection = internalTransaction.Connection;

                        command.Parameters.AddWithValue("@Name", student.Name);
                        command.Parameters.AddWithValue("@Email", student.Email);
                        command.Parameters.AddWithValue("@Id", student.Id);

                        command.ExecuteNonQuery();

                        if (transaction == null)
                            internalTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        internalTransaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar atualizar o aluno no banco de dados.", ex) { Data = { { "Id", student.Id } } };
                    }
                }
            }
        }
    }
}