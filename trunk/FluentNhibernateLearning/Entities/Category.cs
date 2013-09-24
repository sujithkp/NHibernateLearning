
namespace FluentNhibernateLearning.Entities
{
    public class Category
    {
        public virtual int CategoryID { get; set; }

        public virtual string CategoryName { get; set; }

        public virtual string Description { get; set; }

        public virtual byte[] Picture { get; set; }
    }
}
