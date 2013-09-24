using FluentNhibernateLearning.Entities;
using FluentNHibernate.Mapping;

namespace FluentNhibernateLearning.Mappings
{
    public class ProductsMap :ClassMap<Product>
    {
        public ProductsMap()
        {
            Table("Products");
            Id(x => x.ProductId).Not.Nullable();
            Map(x => x.ProductName).Not.Nullable();
            Map(x => x.QuantityPerUnit).Nullable();
            Map(x => x.UnitPrice).Nullable();
            Map(x => x.UnitsInStock).Nullable();
            Map(x => x.UnitsOnOrder).Nullable();
            Map(x => x.ReorderLevel).Nullable();
            Map(x => x.Discontinued).Nullable();
            References(x => x.Category).Column("CategoryID");
            HasOne(x => x.Supplier).ForeignKey("SupplierID");
        }
    }
}
