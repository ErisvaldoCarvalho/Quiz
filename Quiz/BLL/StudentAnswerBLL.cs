using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentAnswerBLL
    {
        private StudentAnswerDAL studentAnswerDAL;
        public StudentAnswerBLL()
        {
            studentAnswerDAL = new StudentAnswerDAL();
        }
        public void Add(StudentAnswer studentAnswer, SqlTransaction transaction = null)
        {
            studentAnswerDAL.Add(studentAnswer, transaction);
        }
        public List<StudentAnswer> GetAll()
        {
            return studentAnswerDAL.GetAll();
        }
        public StudentAnswer GetById(int id)
        {
            return studentAnswerDAL.GetById(id);
        }
        public void Delete(int id, SqlTransaction transaction = null)
        {
            studentAnswerDAL.Delete(id, transaction);
        }
        public void Update(StudentAnswer studentAnswer)
        {
            studentAnswerDAL.Update(studentAnswer);
        }
    }
}