using FluentNHibernate.Mapping;
using FluentNhibernateLearning.Entities;

namespace FluentNhibernateLearning.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Categories");
            Id(x => x.CategoryID).Not.Nullable();
            Map(x => x.CategoryName).Not.Nullable();
            Map(x => x.Description).Nullable();
            Map(x => x.Picture).Nullable();
        }
    }
}
