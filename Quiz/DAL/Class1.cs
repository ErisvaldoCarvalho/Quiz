using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DisciplineDAL
    {
        public void AddDiscipline(Discipline discipline)
        {
            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("INSERT INTO Discipline (Name) VALUES (@Name)", connection);
                command.Parameters.AddWithValue("@Name", discipline.Name);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Discipline> GetAll()
        {
            var disciplines = new List<Discipline>();

            using (var connection = new SqlConnection(Connection.ConnectionString))
            {
                var command = new SqlCommand("SELECT * FROM Discipline", connection);
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
                var command = new SqlCommand("SELECT * FROM Discipline WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", _id);
                connection.Open();
                var reader = command.ExecuteReader();

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

    public class StudentDAL
    {
        private readonly string _connectionString;
        public StudentDAL(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void AddStudent(Student student)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Student (Name, Email) VALUES (@Name, @Email)", connection);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Email", student.Email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Student", connection);
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
    }
    public class QuestionDAL
    {
        private readonly string _connectionString;
        public QuestionDAL(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void AddQuestion(Question question)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Question (Context, Command, ContextImage, IdDiscipline) VALUES (@Context, @Command, @ContextImage, @IdDiscipline)", connection);
                command.Parameters.AddWithValue("@Context", question.Context);
                command.Parameters.AddWithValue("@Command", question.Command);
                command.Parameters.AddWithValue("@ContextImage", question.ContextImage ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@IdDiscipline", question.IdDiscipline);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

