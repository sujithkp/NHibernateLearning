using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNhibernateLearning.Entities
{
    public class Territory
    {
        public virtual string TerritoryID { get; set; }

        public virtual string TerritoryDescription { get; set; }

        public virtual Region Region { get; set; }

        public virtual IList<Employee> Employees { get; set; }
    }
}
