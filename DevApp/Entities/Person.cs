using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApp.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; internal set; }
        public object ProductCategory { get; internal set; }
        public string Purpose { get; internal set; }
        public string Notes { get; internal set; }
    }
}
