using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNhibernateLearning.Entities;
using FluentNhibernateLearning.Lib;
using NHibernate.Criterion;

namespace FluentNhibernateLearning.Dal
{
    public class CustomerDal
    {
        public IList<Customer> GetCustomers()
        {
            return NHibernateHelper.CurrentSession.CreateCriteria<Customer>().List<Customer>();
        }

        public IList<Customer> GetCustomers(string Country)
        {
            return NHibernateHelper.CurrentSession.CreateCriteria<Customer>()
                .Add(Restrictions.InsensitiveLike("Country", Country))
                .List<Customer>();
        }
    }
}
