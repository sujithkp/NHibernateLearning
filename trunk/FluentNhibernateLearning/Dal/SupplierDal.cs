using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNhibernateLearning.Entities;
using FluentNhibernateLearning.Lib;
using NHibernate.Criterion;

namespace FluentNhibernateLearning.Dal
{
    public class SupplierDal
    {
        public IList<Supplier> GetSuppliers()
        {
            return NHibernateHelper.CurrentSession.CreateCriteria<Supplier>().List<Supplier>();
        }

        public IList<Supplier> GetSuppliersOfThisProductCategory(Category category)
        {
            return NHibernateHelper.CurrentSession.CreateCriteria<Supplier>()
                .CreateCriteria("Products")
                .Add(Restrictions.Eq("Category.CategoryID", category.CategoryID))
                .List<Supplier>();
        }
    }
}
