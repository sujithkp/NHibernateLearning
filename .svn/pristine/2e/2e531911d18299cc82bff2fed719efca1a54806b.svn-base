using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNhibernateLearning.Entities;
using FluentNhibernateLearning.Lib;
using NHibernate.Criterion;

namespace FluentNhibernateLearning.Dal
{
    public class ProductDal
    {
        public IList<Product> GetProducts()
        {
            return NHibernateHelper.CurrentSession.CreateCriteria<Product>()
                .List<Product>();
        }

        public IList<Product> GetOutOfStockProducts(int supplierId)
        {
            return
                NHibernateHelper.CurrentSession.CreateCriteria<Product>()
                .Add(Restrictions.InsensitiveLike("Supplier.SupplierID", supplierId))
                .Add(Restrictions.Eq("UnitsInStock", 0))
                .List<Product>();
        }

    }
}
