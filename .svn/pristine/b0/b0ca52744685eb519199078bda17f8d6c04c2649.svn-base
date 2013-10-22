using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace FluentNhibernateLearning.Lib
{
    public class NHibernateHelper
    {
        public static ISession CurrentSession { get; set; }

        static NHibernateHelper()
        {
            Initialize();
        }

        private static void Initialize()
        {
            var db = MsSqlConfiguration.MsSql2008
                .ConnectionString("Data Source = .\\sqlexpress; Initial Catalog = Northwind; Integrated Security=True;");

            CurrentSession = Fluently.Configure()
                .Database(db)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .BuildSessionFactory()
                .OpenSession();
        }
    }
}
