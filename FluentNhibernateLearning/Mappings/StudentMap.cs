﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using FluentNhibernateLearning.Entities;

namespace FluentNhibernateLearning.Mappings
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Id(x => x.PKey).Column("PKey");
            Map(x => x.Name);
            References(x => x.ClassRoom).Column("ClassFK");
        }
    }
}
