using FluentNHibernate.Mapping;
using FluentNhibernateLearning.Entities;

namespace FluentNhibernateLearning.Mappings
{
    public class SupplierMap : ClassMap<Supplier>
    {
        public SupplierMap()
        {
            this.Table("Suppliers");

            Id(x => x.SupplierID).Not.Nullable().GeneratedBy.Increment();
            Map(x => x.CompanyName).Not.Nullable();
            Map(x => x.ContactName);
            Map(x => x.ContactTitle);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.Region);
            Map(x => x.Country);
            Map(x => x.PostalCode);
            Map(x => x.Phone);
            Map(x => x.Fax);
            Map(x => x.HomePage);

            HasMany(x => x.Products).ForeignKeyConstraintName("FK_Products_Suppliers");
        }
    }
}
