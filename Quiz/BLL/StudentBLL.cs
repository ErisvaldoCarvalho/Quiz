using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class StudentBLL
    {
        private readonly StudentDAL studentDAL;
        public StudentBLL()
        {
            studentDAL = new StudentDAL();
        }
        public void Add(Student student)
        {
            try
            {
                studentDAL.Add(student);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar adicionar um estudante.", ex);
            }
        }
        public List<Student> GetAll()
        {
            try
            {
                return studentDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar obter todos os estudantes.", ex);
            }
        }
        public Student GetById(int id)
        {
            try
            {
                return studentDAL.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao tentar obter o estudante com Id = {id}.", ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                studentDAL.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao tentar excluir o estudante com Id = {id}.", ex);
            }
        }
        public void Update(Student student)
        {
            try
            {
                studentDAL.Update(student);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao tentar atualizar o estudante com Id = {student.Id}.", ex);
            }
        }
    }
}