using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person : Human
    {
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string ProductName { get; set; }
        public string Notes { get; set; }
        public string Purpose { get; set; }
        public string ProductCategory { get; set; }
        public string ProductPrice { get; set; }


        public override string GetName()
        {
            FullName = "Person Name";
            return FullName;
        }

        public string GetBase()
        {
            return base.GetName();
        }

        public override string ReturnBaseProperty()
        {
            return base.ReturnBaseProperty();
        }

        public List<Person> CreatePerson()
        {
            Person lPerson = new Person()
            {
                PersonID =  1,
                FullName = "James",
                ProductName = "Bond",
                Notes = "1 10 Ave",
                Purpose = "New York",
                ProductCategory = "NY",
                ProductPrice = "10001"
            };
            List<Person> lList = new List<Person>();
            lList.Add(lPerson);
            Person lPerson1 = new Person()
            {
                PersonID = 2,
                FullName = "Bob",
                ProductName = "Smith",
                Notes = "2 10 Ave",
                Purpose = "New York",
                ProductCategory = "NY",
                ProductPrice = "10001"
            };
            lList.Add(lPerson1);
            return lList;
        }
    }
}
