using System.Collections.Generic;
using FluentNhibernateLearning.Entities;
using FluentNhibernateLearning.Lib;
using NHibernate.Criterion;

namespace FluentNhibernateLearning.Dal
{
    public class EmployeeDal
    {
        public Employee GetEmployee(int employeeId)
        {
            return NHibernateHelper.CurrentSession.CreateCriteria<Employee>()
                .Add(Restrictions.Eq("EmployeeID", employeeId))
                .UniqueResult<Employee>();
        }

        public IList<Employee> GetEmployeesInTheRegion(string region)
        {
            return NHibernateHelper.CurrentSession.CreateCriteria<Employee>()
                .CreateAlias("Territories", "t", NHibernate.SqlCommand.JoinType.InnerJoin)
                .CreateAlias("t.Region", "r", NHibernate.SqlCommand.JoinType.InnerJoin)
                .Add(Restrictions.InsensitiveLike("r.RegionDescription", region, MatchMode.Start))
                .List<Employee>();
        }
    }
}
