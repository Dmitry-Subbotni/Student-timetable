﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MAuditor
    {
        private static MAuditor A;
        [TestInitialize]
        public void ClassInitialize()
        {
            A = new MAuditor
            {
                Number = "",
                Floor = 0,
                Building = "",
                Spacious = 0
            };
        }

        [TestMethod]
        public void Issue_98_1()
        {
            Assert.AreEqual(typeof(Guid), A.Id.GetType(), "Ожидался тип поля Guid");
        }
        [TestMethod]
        public void Issue_98_2()
        {
            Assert.AreEqual(typeof(String), A.Number.GetType(), "Ожидался тип поля string");
        }
        [TestMethod]
        public void Issue_98_3()
        {
            Assert.AreEqual(typeof(Byte), A.Floor.GetType(), "Ожидался тип поля byte");
        }
        [TestMethod]
        public void Issue_98_4()
        {
            Assert.AreEqual(typeof(String), A.Building.GetType(), "Ожидался тип поля string");
        }
        [TestMethod]
        public void Issue_98_5()
        {
            Assert.AreEqual(typeof(int), A.Spacious.GetType(), "Ожидался тип поля int");
        }
    }
}
