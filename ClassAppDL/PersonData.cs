using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace ClassAppDL
{
    public class PersonData
    {
        public void InsertPerson(Person pPerson)
        {
            ClassDatabaseDataContext lDB = new ClassDatabaseDataContext();
            //ldb.InsertPerson("James", "Bond", "10 E 1 Street", "New York", "NY", "11111");
            lDB.InsertPerson(pPerson.FullName, pPerson.ProductName, pPerson.Notes, pPerson.Purpose, pPerson.ProductCategory, pPerson.ProductPrice);
        }
        public List<Person> GetPerson()
        {
            ClassDatabaseDataContext ldb = new ClassDatabaseDataContext();
            var tempPerson = ldb.GetPerson();
            List<Person> lPersonList = new List<Person>();

            foreach (GetPersonResult custOrdersDetail in tempPerson)
            {
                Person lPerson = new Person
                {
                    PersonID = custOrdersDetail.PersonId,
                    FullName = custOrdersDetail.FullName,
                    ProductName = custOrdersDetail.ProductName,
                    Notes = custOrdersDetail.Notes,
                    Purpose = custOrdersDetail.Purpose,
                    ProductCategory = custOrdersDetail.ProductCategory,
                    ProductPrice = custOrdersDetail.ProductPrice

                };
                lPersonList.Add(lPerson);
            }
            return lPersonList;
        }
    }
}
