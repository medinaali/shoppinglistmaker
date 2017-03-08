using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAppDL;
using Entities;

namespace ClassAppBL
{
    public class ProcessPersonBl
    {
        public void ProcessInsertPerson(Person pPerson)
        {
            PersonData lPersonData = new PersonData();
            lPersonData.InsertPerson(pPerson);
        }

        public List<Person> GetAllPeople()
        {
            PersonData lPersonData = new PersonData();
            return lPersonData.GetPerson();
        } 
    }
}
