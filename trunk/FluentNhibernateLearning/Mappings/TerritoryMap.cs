using FluentNHibernate.Mapping;
using FluentNhibernateLearning.Entities;

namespace FluentNhibernateLearning.Mappings
{
    public class TerritoryMap : ClassMap<Territory>
    {
        public TerritoryMap()
        {
            Table("Territories");

            Id(x => x.TerritoryID);
            References(x => x.Region).Column("RegionID");
            Map(x => x.TerritoryDescription);

            HasManyToMany(x => x.Employees).Table("employeeterritories").ParentKeyColumn("TerritoryID")
                .ChildKeyColumn("EmployeeID").LazyLoad();
        }
    }
}
