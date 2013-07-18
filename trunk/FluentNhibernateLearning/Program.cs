using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using FluentNhibernateLearning.Entities;

namespace FluentNhibernateLearning
{
    class Program
    {
        private static ISessionFactory CreateSessionFactory()
        {
            var db = MsSqlConfiguration.MsSql2008
                .ConnectionString("Data Source = FlexiLineDBServer; Initial Catalog = NHibernateLearning; User Id=sa;Password=sa;;");
            return Fluently.Configure()
                .Database(db)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .BuildSessionFactory();
        }

        static void Main(string[] args)
        {
            var sessionFactory = CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                var l = session.CreateCriteria<ClassRoom>().List<ClassRoom>();
            }

        }
    }
}
