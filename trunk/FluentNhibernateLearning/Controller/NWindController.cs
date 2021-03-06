﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNhibernateLearning.Dal;
using FluentNhibernateLearning.Entities;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace FluentNhibernateLearning.Controller
{
    public class NWindController
    {
        #region Properties

        public ProductDal ProductDal { get; set; }

        public CustomerDal CustomerDal { get; set; }

        public EmployeeDal EmployeeDal { get; set; }

        public SupplierDal SupplierDal { get; set; }

        #endregion

        private LogWriter Logger;

        public NWindController()
        {
            Logger = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();

            ProductDal = new ProductDal();

            CustomerDal = new CustomerDal();

            EmployeeDal = new EmployeeDal();

            SupplierDal = new SupplierDal();

            Logger.Write(new LogEntry() { Message = "ready." });
        }

        public IList<Supplier> GetSuppliers()
        {
            return SupplierDal.GetSuppliers();
        }

        public IList<Customer> GetCustomers()
        {
            return CustomerDal.GetCustomers();
        }

        public IList<Customer> GetCustomers(string country)
        {
            return CustomerDal.GetCustomers(country);
        }

        public IList<Product> GetOutOfStockProducts(int supplierId)
        {
            return ProductDal.GetOutOfStockProducts(supplierId);
        }

        public IList<Supplier> GetSuppliersOfThisProductCategory(Category category)
        {
            return SupplierDal.GetSuppliersOfThisProductCategory(category);
        }

        public Employee GetEmployee(int id)
        {
            return EmployeeDal.GetEmployee(id);
        }

        public IList<Employee> GetEmployeesInRegion(string regionId)
        {
            return EmployeeDal.GetEmployeesInTheRegion(regionId);
        }
    }
}
