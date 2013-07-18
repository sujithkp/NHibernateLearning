using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNhibernateLearning.Entities
{
    public class ClassRoom
    {
        public virtual int PKey { get; set; }

        public virtual int Year { get; set; }

        public virtual string Section { get; set; }

        public virtual IList<Student> Students { get; set; }
    }
}
