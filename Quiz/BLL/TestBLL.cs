using System.Collections.Generic;
using System.Data.SqlClient;
using DAL;
using Models;

namespace BLL
{
    public class TestBLL
    {
        private TestDAL testDAL;
        public TestBLL()
        {
            testDAL = new TestDAL();
        }
        public void Add(Test test, SqlTransaction transaction = null)
        {
            testDAL.Add(test, transaction);
        }
        public List<Test> GetAll()
        {
            return testDAL.GetAll();
        }
        public Test GetById(int id)
        {
            return testDAL.GetById(id);
        }
        public void Delete(int id, SqlTransaction transaction = null)
        {
            testDAL.Delete(id, transaction);
        }
        public void Update(Test test, SqlTransaction transaction = null)
        {
            testDAL.Update(test, transaction);
        }
    }
}