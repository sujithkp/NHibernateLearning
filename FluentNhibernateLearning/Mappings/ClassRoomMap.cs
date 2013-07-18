using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNhibernateLearning.Entities;
using FluentNHibernate.Mapping;

namespace FluentNhibernateLearning.Mappings
{
    public class ClassRoomMap :ClassMap<ClassRoom>
    {
        public ClassRoomMap()
        {
            Id(x => x.PKey).Column("PKey");
            Map(x => x.Section);
            Map(x => x.Year);
            HasMany(x => x.Students).Inverse().Cascade.AllDeleteOrphan().KeyColumn("ClassFK");
        }
    }
}
