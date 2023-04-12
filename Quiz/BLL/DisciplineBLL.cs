using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class DisciplineBLL
    {
        private DisciplineDAL disciplineDAL;
        public DisciplineBLL()
        {
            disciplineDAL = new DisciplineDAL();
        }
        public void Add(Discipline _discipline)
        {
            try
            {
                disciplineDAL.Add(_discipline);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Discipline> GetAll()
        {
            try
            {
                return disciplineDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Discipline GetById(int _id)
        {
            try
            {
                return disciplineDAL.GetById(_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int _id)
        {
            try
            {
                disciplineDAL.Delete(_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Discipline _discipline)
        {
            try
            {
                disciplineDAL.Update(_discipline);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
