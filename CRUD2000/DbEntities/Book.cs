using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2000.DbEntities
{
    public class Book : BaseEntites
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}
