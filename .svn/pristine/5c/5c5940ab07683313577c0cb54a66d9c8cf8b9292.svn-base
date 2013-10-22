using FluentNHibernate.Mapping;
using FluentNhibernateLearning.Entities;

namespace FluentNhibernateLearning.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("Customers");

            Id(x => x.CustomerID);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.CompanyName);
            Map(x => x.ContactName);
            Map(x => x.ContactTitle);
            Map(x => x.Country);
            Map(x => x.Fax);
            Map(x => x.Phone);
            Map(x => x.PostalCode);
            Map(x => x.Region);
        }
    }
}
