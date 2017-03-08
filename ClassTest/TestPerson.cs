using System;
using System.Diagnostics;
using ClassAppBL;
using ClassAppDL;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassTest
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestGetName()
        {
            Person lPerson = new Person();
            string lName = lPerson.GetName();
            Assert.IsNotNull(lName);
            int lBase = lPerson.HumanID;
            Assert.AreNotEqual(1, lBase);
            string lBaseName = lPerson.GetBase();
            Assert.IsNotNull(lBaseName);
            // lPerson.BaseProperty cannot be accessed
            string lBaseProperty = lPerson.ReturnBaseProperty();
            Assert.IsNotNull(lBaseProperty);

        }

        [TestMethod]
        public void InsertPersonDl()
        {
            Person lPerson = new Person()
            {
                PersonID = 0,
                FullName = "James",
                ProductName = "Bond",
                Address = "10 Avenue A",
                Purpose = "New York",
                ProductCategory = "NY",
                ProductPrice = "12345"

            };
            PersonData lPersonData = new PersonData();
            lPersonData.InsertPerson(lPerson);
            
        }
        [TestMethod]
        public void InsertPersonBl()
        {
            //Person lPerson = new Person()
            //{
            //    PersonID = 0,
            //    FullName = "James",
            //    ProductName = "Bond",
            //    Address = "10 Avenue A",
            //    Purpose = "New York",
            //    ProductCategory = "NY",
            //    ProductPrice = "12345"

            //};
            Person lPerson = CreatePerson();
            ProcessPersonBl lPersonData = new ProcessPersonBl();
            lPersonData.ProcessInsertPerson(lPerson);

        }

        private Person CreatePerson()
        {
            Person lPerson = new Person()
            {
                PersonID = 0,
                FullName = "James",
                ProductName = "Bond",
                Address = "10 Avenue A",
                Purpose = "New York",
                ProductCategory = "NY",
                ProductPrice = "12345"

            };
            return lPerson;
        }
    }
}
