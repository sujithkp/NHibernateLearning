﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNhibernateLearning.Entities
{
    public class Product
    {
        public virtual int ProductId { get; set; }

        public virtual string ProductName { get; set; }

        public virtual string QuantityPerUnit { get; set; }

        public virtual decimal UnitPrice { get; set; }

        public virtual int UnitsInStock { get; set; }

        public virtual int UnitsOnOrder { get; set; }

        public virtual int ReorderLevel { get; set; }

        public virtual bool Discontinued { get; set; }

        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
