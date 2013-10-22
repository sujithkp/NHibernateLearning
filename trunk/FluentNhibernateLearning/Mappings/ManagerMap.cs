using System;
using FluentNHibernate.Mapping;
using FluentNhibernateLearning.Entities;

namespace FluentNhibernateLearning.Mappings
{
    public class ManagerMap : SubclassMap<Manager>
    {
        public ManagerMap()
        {
            this.Table("Employees");
            //DiscriminatorValue("Manager");

            //Map(x => x.ManagerID);
        }
    }
}
