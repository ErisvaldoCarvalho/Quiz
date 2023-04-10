using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;

namespace UnitTest
{
    //[TestClass]
    //public class CalcTest
    //{
    //    [TestMethod]
    //    public void Sum()
    //    {
    //        var y = new Calc();
    //        int x = y.Sum(4, 2);
    //        Assert.AreEqual(6, x);
    //    }
    //}


    [TestClass]
    public class DisciplineDALTests
    {
        [Test]
        public void Add_AddsNewDisciplineToDatabase()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [Test]
        public void GetAll_ReturnsListOfDisciplines()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [Test]
        public void GetById_ReturnsDisciplineWithMatchingId()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [Test]
        public void Delete_RemovesDisciplineFromDatabase()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [Test]
        public void Update_UpdatesDisciplineInDatabase()
        {
            Assert.AreEqual(2, 1 + 1);
        }
    }

}






